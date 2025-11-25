let num = Number(prompt("Enter a number:"));
let newnum = 0;
let counter = 1;
while (num > 0) {
    if (num % 10 >= 0 && num % 10 <= 4) {
        newnum += (num % 10 * 2 * counter)
    }
    else {
        newnum += (num % 10 - 1) * counter;
    }
    num = Math.floor(num / 10);
    counter *= 10;
}

alert("the new num is: " + newnum)




