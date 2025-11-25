let num = Number(prompt("enter a number"))
let newnum = 0;
while (num > 9) {
    newnum = 0;
    while (num > 0) {
        newnum += num % 10;
        num = Math.floor(num / 10);
    }
    num = newnum;
}

alert("the new num is: " + newnum)