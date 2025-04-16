/*
	Fibonacci Series with Generator
*/

let series = [];

// Parameter determines the number of elements displayed
function* fibonacci(numOfElements) {
  let [a, b] = [0, 1];
  for (let i = 0; i < numOfElements; i++) {
    yield a;
    [a, b] = [b, a + b];
  }
}

for (let value of fibonacci(10)) {
  series.push(value);
}
console.log(series);

console.log("------------------");
series = [];
// Parameter determines the max number of the displayed series
function* fibonacciMax(max) {
  let [a, b] = [0, 1];
  while (a < max) {
    yield a;
    [a, b] = [b, a + b];
  }
}

// The same output as fibonacci(10)
for (let value of fibonacci(10)) {
  series.push(value);
}
console.log(series);
