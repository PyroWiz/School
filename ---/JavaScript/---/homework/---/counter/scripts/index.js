import { showDate, moreDates, showClock, showCountDown } from "./functions.js";

document.querySelector('#btn').addEventListener('click', showDate);
document.addEventListener('DOMContentLoaded', showClock);
document.querySelector('#count').addEventListener('click', showCountDown);

moreDates();