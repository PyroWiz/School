export default class CouterClock {

   //תכונות
   days;
   hours;
   minutes;
   seconds;

   //בנאי
   constructor(days, hours, minutes, seconds) {
      this.days = days;
      this.hours = hours;
      this.minutes = minutes;
      this.seconds = seconds;
   }

   countDown() {
      seconds--;
      //TODO: לעדכן את שאר התכונות
   }
   
}