import { startGame, getOldManNumber } from './functions.js'
import { boardNumbers, oldManNumbers, strikes } from './globals.js'


document.addEventListener('DOMContentLoaded', () => {
    startGame();
    const drawAllBtn = document.getElementById('drawAllBtn');
    if (drawAllBtn) {
        drawAllBtn.addEventListener('click', () => {
            
            boardNumbers.forEach(num => {
                if (!oldManNumbers.includes(num)) {
                    oldManNumbers.push(num);
                }
            });
            
            document.querySelector('#oldMan').innerHTML = `<p>${oldManNumbers.join(', ')}</p>`;
        });
    }
});


document.querySelector('#btn').addEventListener('click', getOldManNumber);