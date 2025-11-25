class Clock {
  constructor(hour, minute, second, country) {
    this.hour = hour;
    this.minute = minute;
    this.second = second;
    this.country = country;
  }

  convertToSeconds() {
    return this.hour * 3600 + this.minute * 60 + this.second;
  }

  show() {
    return `${this.hour.toString().padStart(2, '0')}:${this.minute.toString().padStart(2, '0')}:${this.second.toString().padStart(2, '0')}`;
  }
}

const clocks = [
  new Clock(12, 35, 55, "Israel"),
  new Clock(8, 15, 0, "USA"),
  new Clock(22, 0, 45, "Japan"),
  new Clock(17, 25, 30, "UK"),
  new Clock(6, 45, 15, "India")
];

document.getElementById("output").textContent = clocks.map(
  c => `${c.country}: ${c.show()} (${c.convertToSeconds()} seconds)`
).join("\n");
