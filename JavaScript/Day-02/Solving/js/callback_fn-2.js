<<<<<<< HEAD
/*
A function named processArray that takes an array and a callback function.
The function should apply the callback to each element in the array
and log the results.
Test it by passing an array of numbers and a callback that squares each number
*/

// Process Array Function
function processArray(arr, operation) {
  for (var i = 0; i < arr.length; i++) arr[i] = operation(arr[i]);
  return arr;
}

// Filling an array function
function arrFill(size) {
  var arr = [];
  var num;
  for (var i = 0; i < size; i++) {
    num = Number(prompt("Enter value #" + [i + 1] + " : "));
    while (isNaN(num))
      num = Number(
        prompt("Please Enter a Valid Number for value #" + [i + 1] + " : ")
      );
    arr.push(num);
  }
  return arr;
}

// Main
var size = Number(prompt("Enter the number of elements: "));
while (isNaN(size)) size = Number(prompt("Please Enter a Valid Number: "));

var square = function (number) {
  return number * number;
};

alert(
  "Your array with squared elements: " + processArray(arrFill(size), square)
);
=======
/*
A function named processArray that takes an array and a callback function.
The function should apply the callback to each element in the array
and log the results.
Test it by passing an array of numbers and a callback that squares each number
*/

// Process Array Function
function processArray(arr, operation) {
  for (var i = 0; i < arr.length; i++) arr[i] = operation(arr[i]);
  return arr;
}

// Filling an array function
function arrFill(size) {
  var arr = [];
  var num;
  for (var i = 0; i < size; i++) {
    num = Number(prompt("Enter value #" + [i + 1] + " : "));
    while (isNaN(num))
      num = Number(
        prompt("Please Enter a Valid Number for value #" + [i + 1] + " : ")
      );
    arr.push(num);
  }
  return arr;
}

// Main
var size = Number(prompt("Enter the number of elements: "));
while (isNaN(size)) size = Number(prompt("Please Enter a Valid Number: "));

var square = function (number) {
  return number * number;
};

alert(
  "Your array with squared elements: " + processArray(arrFill(size), square)
);
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
