//date format -> YYYY-MM-DD

export function showDate() {
    debugger;
    let dateInput = document.querySelector('#input_date');

    //אם גיל המשתמש קטן מ-16 נציג הודעה שהוא לא יכול לגשת לטסט ברכב
    let today = new Date();
    let dob = new Date(dateInput.value);

    if (today.getFullYear() - dob.getFullYear() < 16) {
        document.querySelector('#message').innerHTML = `<p>אתה לא יכול לגשת לטסט ברכב</p>`;
    }
    else {
        document.querySelector('#message').innerHTML = `<p>בהצלחה בטסט</p>`;
    }
}

export function moreDates() {
    let now = new Date();

    let dayOfWeek = now.getDay() + 1;
    let day = now.getDate(); // היום בחודש
    let month = now.getMonth() + 1;
    let year = now.getFullYear();
    let time = now.getTime(); // כמות המילישניות שעברו מ 1.1.1970 עד עכשיו
    let hours = now.getHours();
    let minutes = now.getMinutes();
    let seconds = now.getSeconds();

    //console.log(dayOfWeek, day,  month, year);
    //console.log(time);
    console.log(`${hours}:${minutes}:${seconds}`);

}

export function showClock() {
    let section = document.querySelector('#clock');

    setInterval(() => {
        let time = new Date();
        section.innerHTML = `${time.getHours()}:${time.getMinutes()}:${time.getSeconds()}`;
    }, 1000);

    setTimeout(() => {
        alert("Boom");
    }, 3000);
}

export function showCountDown(){
    let section = document.querySelector('#couter');
    //TODO: create a new CounterClock object
    //TODO: Print all the counter data int this format: days : hours : minutes : seconds
    //TODO: apply interval until the time is up
}