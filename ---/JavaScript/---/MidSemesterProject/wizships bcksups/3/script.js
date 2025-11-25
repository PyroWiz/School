const startBtn = document.getElementById('start');
const errorP  = document.getElementById('error');
const setup   = document.getElementById('setup');
const game    = document.getElementById('game');
const boardEl = document.getElementById('board');
const boomAudio = document.getElementById('boom-sound');
const wizard = document.getElementById('wizard');

let board = [], ships = [], remaining = {};

startBtn.addEventListener('click', () => {
  errorP.textContent = '';
  const size = +document.getElementById('board-size').value;
  const counts = {};
  for (let len of [2,3,4,5]) {
    const v = +document.getElementById(`ship-${len}`).value;
    if (isNaN(v) || v < 0) {
      errorP.textContent = 'Enter valid ship numbers.';
      return;
    }
    counts[len] = v;
  }
  // --- Ship fit validation ---
  const totalShipCells = [2,3,4,5].reduce((sum, len) => sum + len * counts[len], 0);
  // Estimate: require at least one cell gap around each ship (not perfect, but prevents obvious overfill)
  const minRequiredCells = [2,3,4,5].reduce((sum, len) => sum + (len + 2) * counts[len], 0);
  const boardCells = size * size;
  if (minRequiredCells > boardCells) {
    errorP.textContent = 'Too many ships for this board size! Reduce ship count or increase board size.';
    return;
  }
  // --- End validation ---
  initGame(size, counts);
});

function initGame(n, counts) {
  board = Array.from({length: n}, ()=>Array(n).fill(0));
  ships = [];
  remaining = {...counts};
  for (let len of [2,3,4,5]) {
    for (let i = 0; i < counts[len]; i++) {
      const ok = placeShip(len);
      if (!ok) {
        errorP.textContent = 'Unable to fit all ships on the board. Please reduce ship count or increase board size.';
        setup.hidden = false;
        game.hidden = true;
        return;
      }
    }
    document.getElementById(`remain-${len}`).textContent = remaining[len];
  }
  setup.hidden = true;
  game.hidden  = false;
  boardEl.style.setProperty('--size', n);
  renderBoard(n);
}

function placeShip(len) {
  const n = board.length;
  let placed = false;
  let attempts = 0;
  const MAX_ATTEMPTS = 200;
  while (!placed && attempts < MAX_ATTEMPTS) {
    attempts++;
    const dir = Math.random() < .5 ? 'h' : 'v';
    const r = Math.floor(Math.random()*n);
    const c = Math.floor(Math.random()*n);
    if (!canPlace(r,c,len,dir)) continue;
    const cells = [];
    for (let k=0; k<len; k++) {
      const rr = r + (dir==='v'?k:0);
      const cc = c + (dir==='h'?k:0);
      board[rr][cc] = 1;
      cells.push({r: rr, c: cc, hit: false});
    }
    ships.push({len, cells});
    placed = true;
  }
  return placed;
}

function canPlace(r,c,len,dir) {
  const n = board.length;
  for (let k = 0; k < len; k++) {
    const rr = r + (dir==='v'?k:0);
    const cc = c + (dir==='h'?k:0);
    if (rr<0||cc<0||rr>=n||cc>=n) return false;
    for (let dr=-1; dr<=1; dr++) for (let dc=-1; dc<=1; dc++) {
      const nr=rr+dr, nc=cc+dc;
      if (nr>=0&&nc>=0&&nr<n&&nc<n && board[nr][nc]===1) return false;
    }
  }
  return true;
}

function renderBoard(n) {
  boardEl.innerHTML = '';
  for (let r=0; r<n; r++) {
    for (let c=0; c<n; c++) {
      const cell = document.createElement('div');
      cell.className = 'cell';
      cell.dataset.r = r;
      cell.dataset.c = c;
      cell.addEventListener('click', onClick);
      boardEl.append(cell);
    }
  }
}

function animateFireballToCell(cell, callback) {
  // Get wizard position (center bottom)
  const wizardRect = wizard.getBoundingClientRect();
  // Start at wizard's hand (roughly center top of wizard image)
  const startX = wizardRect.left + wizardRect.width / 2 - 16;
  const startY = wizardRect.top + 20;

  // Get cell position (center of cell)
  const cellRect = cell.getBoundingClientRect();
  const endX = cellRect.left + cellRect.width / 2 - 16;
  const endY = cellRect.top + cellRect.height / 2 - 16;

  // Calculate deltas for CSS animation
  const dx = endX - startX;
  const dy = endY - startY;

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

  fb.addEventListener('animationend', () => {
    fb.remove();
    if (callback) callback();
  });
}

function showExplosion(cell) {
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
  explosion.style.left = `${rect.left + rect.width/2 - size/2}px`;
  explosion.style.top = `${rect.top + rect.height/2 - size/2}px`;
  explosion.style.pointerEvents = 'none';
  explosion.style.zIndex = '999';
  document.body.appendChild(explosion);
  setTimeout(() => {
    explosion.remove();
  }, 700); // explosion.gif duration
}

function onClick(e) {
  const cell = e.currentTarget;
  if (cell.classList.contains('disabled')) return;
  cell.classList.add('disabled');
  // Animate fireball, then handle hit/miss
  animateFireballToCell(cell, () => {
    const r = +cell.dataset.r, c = +cell.dataset.c;
    if (board[r][c] === 1) {
      showExplosion(cell);
      handleHit(cell, r, c);
    } else {
      cell.classList.add('miss');
    }
  });
}

function handleHit(cell, r, c) {
  cell.classList.add('hit');
  const ship = ships.find(s => s.cells.some(o => o.r===r && o.c===c));
  const part = ship.cells.find(o => o.r===r && o.c===c);
  part.hit = true;
  if (ship.cells.every(o => o.hit)) {
    remaining[ship.len]--;
    document.getElementById(`remain-${ship.len}`).textContent = remaining[ship.len];
    explode(ship.cells);
  }
}

function explode(cells) {
  boomAudio.currentTime = 0;
  boomAudio.play();
  cells.forEach(o => {
    const sel = `.cell[data-r="${o.r}"][data-c="${o.c}"]`;
    const el = document.querySelector(sel);
    // replace hit color with sunk
    el.classList.remove('hit');
    el.classList.add('sunk');
    // play boom animation
    el.classList.add('boom');
    showExplosion(el);
    setTimeout(()=> el.classList.remove('boom'), 600);
  });
}
