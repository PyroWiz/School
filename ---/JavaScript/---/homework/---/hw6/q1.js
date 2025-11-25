class Counter {
  constructor() {
    this.value = 0;
  }

  initialize(val) {
    this.value = val;
  }

  increment() {
    this.value++;
  }

  go() {
    let result = '';
    for (let i = 0; i <= this.value; i++) {
      result += i + '\n';
    }
    return result;
  }
}

const counter = new Counter();

function initializeCounter() {
  const val = parseInt(document.getElementById("initVal").value);
  if (!isNaN(val)) counter.initialize(val);
  document.getElementById("output").textContent = `Initialized to ${val}`;
}

function incrementCounter() {
  counter.increment();
  document.getElementById("output").textContent = `Incremented to ${counter.value}`;
}

function goCounter() {
  document.getElementById("output").textContent = counter.go();
}
