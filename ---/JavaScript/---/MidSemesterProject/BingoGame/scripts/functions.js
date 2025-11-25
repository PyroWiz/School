import { boardNumbers, oldManNumbers, strikes } from './globals.js';

export function getOldManNumber()
{
    let n = getRandomNumber();

    while (oldManNumbers.some((num) => num == n))
        n = getRandomNumber();

    oldManNumbers.push(n);
    document.querySelector('#oldMan').innerHTML = `<p>${oldManNumbers.join(', ')}</p>`;
}

function getRandomNumber()
{
    let num = Math.floor(Math.random() * (100 - 1) + 1);
    return num;
}

export function startGame()
{
    let board = document.querySelector('#board');
    let table = createTable(7, 7);
    board.appendChild(table);
}

function createTable(rows, cols)
{
    let table = document.createElement('table');
    for (let i = 0; i < rows; i++)
    {
        let tr = document.createElement('tr');
        for (let j = 0; j < cols; j++)
        {
            let td = document.createElement('td');
            let n = getRandomNumber();

            
            while (boardNumbers.some((num) => num == n))
                n = getRandomNumber();

           
            boardNumbers.push(n);
            td.textContent = n;
            td.addEventListener('click', checkValue);

            tr.appendChild(td);
        }
        table.appendChild(tr);
    }

    return table;
}

function resetGame() {
    
    boardNumbers.length = 0;
    oldManNumbers.length = 0;
    strikes.length = 0;
    
    document.querySelector('#board').innerHTML = '';
    document.querySelector('#oldMan').innerHTML = '';
    
    startGame();
}

function checkVictory() {
    const table = document.querySelector('#board table');
    if (!table) return false;
    const rows = table.rows.length;
    const cols = table.rows[0].cells.length;

    
    for (let i = 0; i < rows; i++) {
        let fullRow = true;
        for (let j = 0; j < cols; j++) {
            if (table.rows[i].cells[j].textContent !== 'X') {
                fullRow = false;
                break;
            }
        }
        if (fullRow) return true;
    }

   
    for (let j = 0; j < cols; j++) {
        let fullCol = true;
        for (let i = 0; i < rows; i++) {
            if (table.rows[i].cells[j].textContent !== 'X') {
                fullCol = false;
                break;
            }
        }
        if (fullCol) return true;
    }

    
    let fullDiag1 = true;
    for (let i = 0; i < Math.min(rows, cols); i++) {
        if (table.rows[i].cells[i].textContent !== 'X') {
            fullDiag1 = false;
            break;
        }
    }
    if (fullDiag1) return true;

  
    let fullDiag2 = true;
    for (let i = 0; i < Math.min(rows, cols); i++) {
        if (table.rows[i].cells[cols - i - 1].textContent !== 'X') {
            fullDiag2 = false;
            break;
        }
    }
    if (fullDiag2) return true;

    return false;
}


function checkValue(event)
{
    let tdNum = Number(event.target.textContent);
    let exists = oldManNumbers.some((num) => num == tdNum);
    if (exists) {
        event.target.textContent = 'X';
        event.target.classList.add('marked'); 
        event.target.removeEventListener('click', checkValue); 
        if (checkVictory()) {
            alert('Victory! You completed a row, column, or diagonal!');
            resetGame();
            return;
        }
    } else {
        strikes.push(1);
        let totalStrikes = strikes.reduce((total, num) => total + num, 0);
        if (totalStrikes == 3)
        {
            alert('Game Over! You clicked 3 times on numbers that were not drawn.');
            resetGame();
        }
        else
        {
            alert(`המספר לא הוגרל! פסילה ${totalStrikes}`);
        }
    }
}