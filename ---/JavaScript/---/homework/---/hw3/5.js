let guess = 0;
let attempts = 0;
let num = Number(prompt("enter number"));
do {
    guess = Number(prompt("guess the number"))
    attempts++;
    Size(num, guess);
} while (num != guess)

function Size(num, guess) {
    if (guess > num) {
        alert("bigger!")
    }
    else if (guess < num) {
        alert("smaller!")
    }
    else {
        alert("you guessed the number!")
    }
}


