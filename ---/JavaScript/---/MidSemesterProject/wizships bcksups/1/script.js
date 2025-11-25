const startBtn = document.getElementById('start');
const errorP  = document.getElementById('error');
const setup   = document.getElementById('setup');
const game    = document.getElementById('game');
const boardEl = document.getElementById('board');
const boomAudio = document.getElementById('boom-sound');

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
  initGame(size, counts);
});

function initGame(n, counts) {
  board = Array.from({length: n}, ()=>Array(n).fill(0));
  ships = [];
  remaining = {...counts};
  for (let len of [2,3,4,5]) {
    for (let i = 0; i < counts[len]; i++) placeShip(len);
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
  while (!placed) {
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

function onClick(e) {
  const cell = e.currentTarget;
  if (cell.classList.contains('disabled')) return;
  cell.classList.add('disabled');
  const r = +cell.dataset.r, c = +cell.dataset.c;
  if (board[r][c] === 1) handleHit(cell, r, c);
  else cell.classList.add('miss');
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
    setTimeout(()=> el.classList.remove('boom'), 600);
  });
}
