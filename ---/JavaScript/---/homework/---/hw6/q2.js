class Frog {
  constructor(name, color, age, weight) {
    this.name = name;
    this.color = color;
    this.age = age;
    this.weight = weight;
  }

  show() {
    return `Name: ${this.name}, Color: ${this.color}, Age: ${this.age}, Weight: ${this.weight}`;
  }

  quack() {
    const times = Math.floor((this.age * this.weight) / 2);
    return "quack!!!!\n".repeat(times);
  }
}

let frog;

function createFrog() {
  const name = document.getElementById("name").value;
  const color = document.getElementById("color").value;
  const age = parseInt(document.getElementById("age").value);
  const weight = parseFloat(document.getElementById("weight").value);
  frog = new Frog(name, color, age, weight);
  document.getElementById("output").textContent = "Frog created.";
}

function showFrog() {
  if (frog) {
    document.getElementById("output").textContent = frog.show();
  }
}

function quackFrog() {
  if (frog) {
    document.getElementById("output").textContent = frog.quack();
  }
}
