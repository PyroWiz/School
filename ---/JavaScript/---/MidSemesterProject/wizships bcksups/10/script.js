const startBtn = document.getElementById('start');
const errorP = document.getElementById('error');
const setup = document.getElementById('setup');
const game = document.getElementById('game');
const boardEl = document.getElementById('board');
const boomAudio = document.getElementById('boom-sound');
boomAudio.volume = 0.25; // Lower the boom sound volume
const wizard = document.getElementById('wizard');
const placeholderBtn = document.getElementById('powerup-placeholder');

// Hide victory screen on page load
const victory = document.getElementById('victory-screen');
if (victory) victory.style.display = 'none';

let board = [], ships = [], remaining = {};

// --- Acquired Power-up (hidden in a random cell) ---
let acquiredPowerCell = null;
let acquiredPowerAvailable = false;
const acquiredBtn = document.getElementById('powerup-meteor');
if (acquiredBtn)
{
  acquiredBtn.style.display = 'none'; // Hide by default
  acquiredBtn.disabled = true;
}

function showAcquiredPopup()
{
  // Simple popup for now
  const popup = document.createElement('div');
  popup.textContent = 'You found a hidden power-up!';
  popup.style.position = 'fixed';
  popup.style.left = '50%';
  popup.style.top = '30%';
  popup.style.transform = 'translate(-50%, -50%)';
  popup.style.background = '#fffbe6';
  popup.style.color = '#333';
  popup.style.padding = '24px 36px';
  popup.style.fontSize = '1.3rem';
  popup.style.border = '2px solid #e1c340';
  popup.style.borderRadius = '12px';
  popup.style.boxShadow = '0 4px 24px #0002';
  popup.style.zIndex = '3000';
  document.body.appendChild(popup);
  setTimeout(() => popup.remove(), 1800);
}

startBtn.addEventListener('click', () =>
{
  errorP.textContent = '';
  const size = +document.getElementById('board-size').value;
  const counts = {};
  for (let len of [2, 3, 4, 5])
  {
    const v = +document.getElementById(`ship-${len}`).value;
    if (isNaN(v) || v < 0)
    {
      errorP.textContent = 'Enter valid ship numbers.';
      return;
    }
    counts[len] = v;
  }
  // --- Ship fit validation ---
  const totalShipCells = [2, 3, 4, 5].reduce((sum, len) => sum + len * counts[len], 0);
  // Estimate: require at least one cell gap around each ship (not perfect, but prevents obvious overfill)
  const minRequiredCells = [2, 3, 4, 5].reduce((sum, len) => sum + (len + 2) * counts[len], 0);
  const boardCells = size * size;
  if (minRequiredCells > boardCells)
  {
    errorP.textContent = 'Too many ships for this board size! Reduce ship count or increase board size.';
    return;
  }
  // --- End validation ---
  initGame(size, counts);
});

function initGame(n, counts)
{
  board = Array.from({ length: n }, () => Array(n).fill(0));
  ships = [];
  remaining = { ...counts };
  // --- Place acquired power-up in a random cell ---
  acquiredPowerAvailable = false;
  if (acquiredBtn)
  {
    acquiredBtn.style.display = 'none';
    acquiredBtn.disabled = true;
  }
  const totalCells = n * n;
  const idx = Math.floor(Math.random() * totalCells);
  acquiredPowerCell = { r: Math.floor(idx / n), c: idx % n };
  for (let len of [2, 3, 4, 5])
  {
    for (let i = 0; i < counts[len]; i++)
    {
      const ok = placeShip(len);
      if (!ok)
      {
        errorP.textContent = 'Unable to fit all ships on the board. Please reduce ship count or increase board size.';
        setup.hidden = false;
        game.hidden = true;
        return;
      }
    }
    document.getElementById(`remain-${len}`).textContent = remaining[len];
  }
  setup.hidden = true;
  game.hidden = false;
  boardEl.style.setProperty('--size', n);
  renderBoard(n);
}

function placeShip(len)
{
  const n = board.length;
  let placed = false;
  let attempts = 0;
  const MAX_ATTEMPTS = 200;
  while (!placed && attempts < MAX_ATTEMPTS)
  {
    attempts++;
    const dir = Math.random() < .5 ? 'h' : 'v';
    const r = Math.floor(Math.random() * n);
    const c = Math.floor(Math.random() * n);
    if (!canPlace(r, c, len, dir)) continue;
    const cells = [];
    for (let k = 0; k < len; k++)
    {
      const rr = r + (dir === 'v' ? k : 0);
      const cc = c + (dir === 'h' ? k : 0);
      board[rr][cc] = 1;
      cells.push({ r: rr, c: cc, hit: false });
    }
    ships.push({ len, cells });
    placed = true;
  }
  return placed;
}

function canPlace(r, c, len, dir)
{
  const n = board.length;
  for (let k = 0; k < len; k++)
  {
    const rr = r + (dir === 'v' ? k : 0);
    const cc = c + (dir === 'h' ? k : 0);
    if (rr < 0 || cc < 0 || rr >= n || cc >= n) return false;
    for (let dr = -1; dr <= 1; dr++) for (let dc = -1; dc <= 1; dc++)
    {
      const nr = rr + dr, nc = cc + dc;
      if (nr >= 0 && nc >= 0 && nr < n && nc < n && board[nr][nc] === 1) return false;
    }
  }
  return true;
}

function renderBoard(n)
{
  boardEl.innerHTML = '';
  for (let r = 0; r < n; r++)
  {
    for (let c = 0; c < n; c++)
    {
      const cell = document.createElement('div');
      cell.className = 'cell';
      cell.dataset.r = r;
      cell.dataset.c = c;
      cell.addEventListener('click', onClick);
      boardEl.append(cell);
    }
  }
}

function animateFireballToCell(cell, callback)
{
  // Get wizard position (center bottom)
  const wizardRect = wizard.getBoundingClientRect();
  // Start at wizard's staff tip (top right area of wizard image)
  const startX = wizardRect.right - wizardRect.width * 0.12 - 27;
  const startY = wizardRect.top + wizardRect.height * 0.10;

  // --- FIRE ORIGIN EFFECT ---
  const fire = document.createElement('div');
  fire.className = 'fire-origin';
  fire.style.position = 'fixed';
  fire.style.left = `${startX - 8}px`; // move more to the left
  fire.style.top = `${startY - 18}px`; // move more higher
  fire.style.zIndex = '201';
  fire.style.width = '44px';
  fire.style.height = '44px';
  document.body.appendChild(fire);
  fire.addEventListener('animationend', () => fire.remove());

  // Get cell position (center of cell)
  const cellRect = cell.getBoundingClientRect();
  const endX = cellRect.left + cellRect.width / 2 - 16;
  const endY = cellRect.top + cellRect.height / 2 - 16;

  // Calculate deltas for CSS animation
  const dx = endX - startX;
  const dy = endY - startY;

  // Calculate distance and duration for constant speed
  const distance = Math.sqrt(dx * dx + dy * dy);
  const speed = 900; // pixels per second (adjust as desired)
  const duration = distance / speed; // in seconds

  // Create a new fireball div
  const fb = document.createElement('div');
  fb.className = 'fireball animate';
  fb.style.position = 'fixed';
  fb.style.left = `${startX}px`;
  fb.style.top = `${startY}px`;
  fb.style.setProperty('--dx', `${dx}px`);
  fb.style.setProperty('--dy', `${dy}px`);
  fb.style.width = '32px';
  fb.style.height = '32px';
  fb.style.opacity = '1';
  fb.style.pointerEvents = 'none';
  fb.style.zIndex = '200';
  fb.style.animationDuration = duration + 's'; // Set duration dynamically
  // Use fireball.webp as the fireball image
  const img = document.createElement('img');
  img.src = 'fireball.webp';
  img.alt = 'Fireball';
  img.style.width = '100%';
  img.style.height = '100%';
  img.style.display = 'block';
  img.style.transform = 'scaleY(-1)'; // Flip the image vertically
  fb.appendChild(img);

  document.body.appendChild(fb);

  fb.addEventListener('animationend', () =>
  {
    fb.remove();
    if (callback) callback();
  });
}

function showExplosion(cell)
{
  // Get cell position on the page
  const rect = cell.getBoundingClientRect();
  const explosion = document.createElement('img');
  explosion.src = 'explosion.gif';
  explosion.alt = 'Explosion';
  explosion.className = 'explosion-anim-global';
  explosion.style.position = 'fixed';
  // Make explosion bigger than cell (e.g. 1.7x)
  const size = Math.max(rect.width, rect.height) * 1.7;
  explosion.style.width = `${size}px`;
  explosion.style.height = `${size}px`;
  explosion.style.left = `${rect.left + rect.width / 2 - size / 2}px`;
  explosion.style.top = `${rect.top + rect.height / 2 - size / 2}px`;
  explosion.style.pointerEvents = 'none';
  explosion.style.zIndex = '999';
  document.body.appendChild(explosion);
  setTimeout(() =>
  {
    explosion.remove();
  }, 700); // explosion.gif duration
}

function showWatersplash(cell)
{
  // Get cell position on the page
  const rect = cell.getBoundingClientRect();
  const splash = document.createElement('img');
  // Force reload of GIF by appending a unique query string
  splash.src = 'water.gif?' + Date.now();
  splash.alt = 'Splash';
  splash.className = 'watersplash-anim-global';
  splash.style.position = 'fixed';
  // Make splash bigger than cell (e.g. 1.5x)
  const size = Math.max(rect.width, rect.height) * 1.5;
  splash.style.width = `${size}px`;
  splash.style.height = `${size}px`;
  splash.style.left = `${rect.left + rect.width / 2 - size / 2}px`;
  splash.style.top = `${rect.top + rect.height / 2 - size / 2}px`;
  splash.style.pointerEvents = 'none';
  splash.style.zIndex = '999';
  document.body.appendChild(splash);
  setTimeout(() =>
  {
    splash.remove();
  }, 600); // water.gif duration
}

let lightningActive = false;
let lightningUsed = false;
let earthquakeActive = false;
let earthquakeUsed = false;
let meteorActive = false;
let meteorUsed = false;

const lightningBtn = document.getElementById('powerup-lightning');
const earthquakeBtn = document.getElementById('powerup-earthquake');
if (lightningBtn)
{
  lightningBtn.addEventListener('click', () =>
  {
    if (lightningUsed) return;
    lightningActive = true;
    earthquakeActive = false;
    lightningBtn.classList.add('active');
    if (earthquakeBtn) earthquakeBtn.classList.remove('active');
  });
}
if (earthquakeBtn)
{
  earthquakeBtn.addEventListener('click', () =>
  {
    if (earthquakeUsed) return;
    earthquakeActive = true;
    lightningActive = false;
    earthquakeBtn.classList.add('active');
    if (lightningBtn) lightningBtn.classList.remove('active');
  });
}
if (acquiredBtn)
{
  acquiredBtn.addEventListener('click', () =>
  {
    if (meteorUsed || !acquiredPowerAvailable) return;
    meteorActive = true;
    acquiredBtn.classList.add('active');
    acquiredBtn.disabled = false;
    // Deactivate other powerups
    lightningActive = false;
    earthquakeActive = false;
    if (lightningBtn) lightningBtn.classList.remove('active');
    if (earthquakeBtn) earthquakeBtn.classList.remove('active');
  });
}

function onClick(e)
{
  const cell = e.currentTarget;
  if (cell.classList.contains('disabled')) return;
  // --- Check for acquired power-up ---
  if (!acquiredPowerAvailable && acquiredPowerCell && +cell.dataset.r === acquiredPowerCell.r && +cell.dataset.c === acquiredPowerCell.c)
  {
    acquiredPowerAvailable = true;
    if (acquiredBtn)
    {
      acquiredBtn.style.display = '';
      acquiredBtn.disabled = false;
    }
    if (placeholderBtn) placeholderBtn.style.display = 'none';
    // Highlight the cell where the power-up was picked up
    cell.classList.add('powerup-source');
    // Glow the power-up button for 1 second
    if (acquiredBtn) {
      acquiredBtn.classList.add('powerup-glow');
      setTimeout(() => acquiredBtn.classList.remove('powerup-glow'), 1000);
    }
    showAcquiredPopup();
  }
  // Meteor Strike Powerup
  if (meteorActive && !meteorUsed)
  {
    meteorActive = false;
    meteorUsed = true;
    acquiredBtn.classList.remove('active');
    acquiredBtn.disabled = true;
    const r = +cell.dataset.r, c = +cell.dataset.c;
    meteorStrikeAttack(r, c);
    return;
  }
  // Lightning Bolt Powerup
  if (lightningActive && !lightningUsed)
  {
    lightningActive = false;
    lightningUsed = true;
    lightningBtn.classList.remove('active');
    lightningBtn.disabled = true;
    // 3x3 area attack
    const r = +cell.dataset.r, c = +cell.dataset.c;
    areaAttack(r, c);
    return;
  }
  // Earthquake Powerup
  if (earthquakeActive && !earthquakeUsed)
  {
    earthquakeActive = false;
    earthquakeUsed = true;
    earthquakeBtn.classList.remove('active');
    earthquakeBtn.disabled = true;
    const r = +cell.dataset.r;
    rowQuakeAttack(r);
    return;
  }
  cell.classList.add('disabled');
  // Animate fireball, then handle hit/miss
  animateFireballToCell(cell, () =>
  {
    const r = +cell.dataset.r, c = +cell.dataset.c;
    if (board[r][c] === 1)
    {
      showExplosion(cell);
      handleHit(cell, r, c);
    } else
    {
      cell.classList.add('miss');
      showWatersplash(cell);
    }
  });
}

function handleHit(cell, r, c)
{
  cell.classList.add('hit');
  const ship = ships.find(s => s.cells.some(o => o.r === r && o.c === c));
  const part = ship.cells.find(o => o.r === r && o.c === c);
  part.hit = true;
  if (ship.cells.every(o => o.hit))
  {
    remaining[ship.len]--;
    document.getElementById(`remain-${ship.len}`).textContent = remaining[ship.len];
    explode(ship.cells, () =>
    {
      // After explosion, check for victory
      if (Object.values(remaining).every(v => v === 0))
      {
        showVictoryScreen();
      }
    });
  }
}

function explode(cells, callback)
{
  boomAudio.currentTime = 0;
  boomAudio.play();
  // Stop boom sound after 2 seconds
  setTimeout(() =>
  {
    boomAudio.pause();
    boomAudio.currentTime = 0;
  }, 2000);
  let finished = 0;
  cells.forEach((o, idx) =>
  {
    const sel = `.cell[data-r="${o.r}"][data-c="${o.c}"]`;
    const el = document.querySelector(sel);
    el.classList.remove('hit');
    el.classList.add('sunk');
    el.classList.add('boom');
    // Show explosion effect on each cell
    showExplosion(el);
    setTimeout(() =>
    {
      el.classList.remove('boom');
      finished++;
      if (finished === cells.length && callback) callback();
    }, 600);
  });
}

function showLightning(cell)
{
  // Get cell position
  const rect = cell.getBoundingClientRect();
  const lightning = document.createElement('div');
  lightning.style.position = 'fixed';
  lightning.style.left = `${rect.left + rect.width / 2 - 12}px`;
  lightning.style.top = `${rect.top - 16}px`;
  lightning.style.width = '24px';
  lightning.style.height = `${rect.height + 32}px`;
  lightning.style.pointerEvents = 'none';
  lightning.style.zIndex = '1200';
  lightning.style.background = 'linear-gradient(to bottom, #fff 0%, #f7e600 60%, #ffe066 100%)';
  lightning.style.borderRadius = '8px';
  lightning.style.boxShadow = '0 0 24px 8px #f7e600, 0 0 60px 20px #fff70044';
  lightning.style.opacity = '0.95';
  lightning.style.transform = 'skewX(-12deg)';
  lightning.style.animation = 'lightning-strike 0.32s cubic-bezier(.7,0,.7,1) forwards';
  document.body.appendChild(lightning);
  setTimeout(() => lightning.remove(), 320);
}

function showSkyLightning(centerCell, callback)
{
  // Get cell position (center of cell)
  const rect = centerCell.getBoundingClientRect();
  const targetX = rect.left + rect.width / 2 - 22; // 44px wide SVG
  const targetY = rect.top + rect.height / 2 - 32; // 64px tall SVG

  // Create the lightning bolt div
  const bolt = document.createElement('div');
  bolt.className = 'sky-lightning-anim-global';
  bolt.style.position = 'fixed';
  bolt.style.left = `${targetX}px`;
  bolt.style.top = `-80px`;
  bolt.style.width = '44px';
  bolt.style.height = '64px';
  bolt.style.zIndex = '1201';
  bolt.style.pointerEvents = 'none';
  // Animate to target position
  bolt.style.animation = `sky-lightning-bolt-zap 0.10s cubic-bezier(.7,0,.7,1) forwards`;
  // Store the final Y position for the animation
  bolt.style.setProperty('--targetY', `${targetY + 8}px`); // +8 for visual alignment

  // SVG lightning bolt as background
  bolt.innerHTML = `<div class="sky-bolt-svg"></div>`;
  document.body.appendChild(bolt);
  bolt.addEventListener('animationend', () =>
  {
    bolt.remove();
    if (callback) callback();
  });
}

function areaAttack(centerR, centerC)
{
  const n = board.length;
  const sel = `.cell[data-r="${centerR}"][data-c="${centerC}"]`;
  const centerCell = document.querySelector(sel);
  if (centerCell)
  {
    showSkyLightning(centerCell, () =>
    {
      // After sky lightning, do the area attack
      for (let dr = -1; dr <= 1; dr++)
      {
        for (let dc = -1; dc <= 1; dc++)
        {
          const r = centerR + dr;
          const c = centerC + dc;
          if (r >= 0 && r < n && c >= 0 && c < n)
          {
            const sel = `.cell[data-r="${r}"][data-c="${c}"]`;
            const cell = document.querySelector(sel);
            if (cell && !cell.classList.contains('disabled'))
            {
              // --- Check for acquired power-up ---
              if (!acquiredPowerAvailable && acquiredPowerCell && r === acquiredPowerCell.r && c === acquiredPowerCell.c)
              {
                acquiredPowerAvailable = true;
                if (acquiredBtn)
                {
                  acquiredBtn.style.display = '';
                  acquiredBtn.disabled = false;
                }
                if (placeholderBtn) placeholderBtn.style.display = 'none';
                showAcquiredPopup();
              }
              cell.classList.add('disabled');
              showLightning(cell);
              // Add frazzle effect
              cell.classList.add('frazzled');
              setTimeout(() =>
              {
                cell.classList.remove('frazzled');
              }, 380); // match CSS animation duration
              setTimeout(() =>
              {
                const r = +cell.dataset.r, c = +cell.dataset.c;
                if (board[r][c] === 1)
                {
                  showExplosion(cell);
                  handleHit(cell, r, c);
                } else
                {
                  cell.classList.add('miss');
                  showWatersplash(cell);
                }
              }, 200);
            }
          }
        }
      }
    });
  }
}

function rowQuakeAttack(rowIdx)
{
  const n = board.length;
  // Select all cells in the row
  const rowCells = [];
  for (let c = 0; c < n; c++)
  {
    const sel = `.cell[data-r="${rowIdx}"][data-c="${c}"]`;
    const cell = document.querySelector(sel);
    if (cell && !cell.classList.contains('disabled'))
    {
      rowCells.push(cell);
    }
  }
  // Animate row shake
  rowCells.forEach(cell => cell.classList.add('row-quake'));
  // Show dust clouds
  setTimeout(() =>
  {
    rowCells.forEach(cell =>
    {
      showDustCloud(cell);
    });
  }, 120);
  // Damage all cells in the row after short delay
  setTimeout(() =>
  {
    rowCells.forEach(cell =>
    {
      const r = +cell.dataset.r, c = +cell.dataset.c;
      // --- Check for acquired power-up ---
      if (!acquiredPowerAvailable && acquiredPowerCell && r === acquiredPowerCell.r && c === acquiredPowerCell.c)
      {
        acquiredPowerAvailable = true;
        if (acquiredBtn)
        {
          acquiredBtn.style.display = '';
          acquiredBtn.disabled = false;
        }
        if (placeholderBtn) placeholderBtn.style.display = 'none';
        showAcquiredPopup();
      }
      cell.classList.add('disabled');
      if (board[r][c] === 1)
      {
        showExplosion(cell);
        handleHit(cell, r, c);
      } else
      {
        cell.classList.add('miss');
        showWatersplash(cell);
      }
      cell.classList.remove('row-quake');
    });
  }, 350);
}

function showDustCloud(cell)
{
  const rect = cell.getBoundingClientRect();
  const dust = document.createElement('div');
  dust.className = 'dust-cloud';
  dust.style.left = `${rect.left + rect.width / 2 - 30}px`;
  dust.style.top = `${rect.top + rect.height / 2 - 16}px`;
  document.body.appendChild(dust);
  setTimeout(() => dust.remove(), 600);
}

function showVictoryScreen()
{
  const victory = document.getElementById('victory-screen');
  if (victory) victory.style.display = 'flex';
}

document.getElementById('restart-btn').addEventListener('click', () =>
{
  location.reload();
});

function meteorStrikeAttack(centerR, centerC)
{
  const n = board.length;
  const sel = `.cell[data-r="${centerR}"][data-c="${centerC}"]`;
  const centerCell = document.querySelector(sel);
  if (!centerCell) return;
  showMeteor(centerCell, () =>
  {
    // After meteor lands, do the 4x4 area attack
    for (let dr = -2; dr <= 2; dr++)
    {
      for (let dc = -2; dc <= 2; dc++)
      {
        const r = centerR + dr;
        const c = centerC + dc;
        if (r >= 0 && r < n && c >= 0 && c < n)
        {
          const sel = `.cell[data-r="${r}"][data-c="${c}"]`;
          const cell = document.querySelector(sel);
          if (cell)
          {
            // Always show explosion, even if already damaged
            setTimeout(() =>
            {
              showMeteorExplosion(cell);
              if (!cell.classList.contains('disabled'))
              {
                cell.classList.add('disabled');
                if (board[r][c] === 1)
                {
                  handleHit(cell, r, c);
                } else
                {
                  cell.classList.add('miss');
                  showWatersplash(cell);
                }
              }
            }, 120);
          }
        }
      }
    }
  });
}

function showMeteor(targetCell, callback)
{
  // Get cell position (center of cell)
  const rect = targetCell.getBoundingClientRect();
  const targetX = rect.left + rect.width / 2 - 36; // 72px meteor
  const targetY = rect.top + rect.height / 2 - 36;
  // Start offscreen top right, more horizontal (steeper by 20%)
  const startX = window.innerWidth + 80;
  // Calculate a more horizontal startY
  const deltaY = targetY + 36 + 120; // vertical distance to target from top
  const deltaX = targetX - startX;
  const newDeltaY = deltaY * 0.8; // 20% more horizontal
  const adjustedStartY = targetY + 36 - newDeltaY;
  const startY = adjustedStartY;
  // Create meteor div
  const meteor = document.createElement('img');
  meteor.className = 'meteor-anim-global';
  meteor.src = 'meteor.webp';
  meteor.alt = 'Meteor';
  meteor.style.position = 'fixed';
  meteor.style.left = `${startX}px`;
  meteor.style.top = `${startY}px`;
  meteor.style.width = '72px';
  meteor.style.height = '72px';
  meteor.style.zIndex = '1300';
  meteor.style.pointerEvents = 'none';
  // Fire trail
  const trail = document.createElement('div');
  trail.className = 'meteor-fire-trail';
  trail.style.position = 'fixed';
  trail.style.left = `${startX + 16}px`;
  trail.style.top = `${startY + 48}px`;
  trail.style.width = '32px';
  trail.style.height = '96px';
  trail.style.zIndex = '1299';
  trail.style.pointerEvents = 'none';
  document.body.appendChild(trail);
  document.body.appendChild(meteor);
  // Animate both
  meteor.animate([
    { left: `${startX}px`, top: `${startY}px`, transform: 'rotate(0deg) scale(1.1)', opacity: 0.95 },
    { left: `${targetX}px`, top: `${targetY}px`, transform: 'rotate(0deg) scale(1.22)', opacity: 1 }
  ], {
    duration: 420,
    easing: 'cubic-bezier(.7,0,.7,1)',
    fill: 'forwards'
  });
  trail.animate([
    { left: `${startX + 16}px`, top: `${startY + 48}px`, opacity: 0.85 },
    { left: `${targetX + 16}px`, top: `${targetY + 48}px`, opacity: 0.1 }
  ], {
    duration: 420,
    easing: 'cubic-bezier(.7,0,.7,1)',
    fill: 'forwards'
  });
  setTimeout(() =>
  {
    meteor.remove();
    trail.remove();
    if (callback) callback();
  }, 420);
}

function showMeteorExplosion(cell)
{
  // Get cell position on the page
  const rect = cell.getBoundingClientRect();
  const explosion = document.createElement('div');
  explosion.className = 'meteor-explosion-anim';
  explosion.style.position = 'fixed';
  const size = Math.max(rect.width, rect.height) * 2.2;
  explosion.style.width = `${size}px`;
  explosion.style.height = `${size}px`;
  explosion.style.left = `${rect.left + rect.width / 2 - size / 2}px`;
  explosion.style.top = `${rect.top + rect.height / 2 - size / 2}px`;
  explosion.style.pointerEvents = 'none';
  explosion.style.zIndex = '1301';
  explosion.innerHTML = `<div class="meteor-explosion-svg"></div>`;
  document.body.appendChild(explosion);
  setTimeout(() =>
  {
    explosion.remove();
  }, 700);
}

document.getElementById('meteor-test-btn').addEventListener('click', () =>
{
  acquiredPowerAvailable = true;
  if (acquiredBtn)
  {
    acquiredBtn.style.display = '';
    acquiredBtn.disabled = false;
  }
  if (placeholderBtn) placeholderBtn.style.display = 'none';
});
