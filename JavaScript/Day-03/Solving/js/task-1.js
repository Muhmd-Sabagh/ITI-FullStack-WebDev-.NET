/*
A function that take an array of persons’ names
and return two random names of them.
*/

// Random Names function
function randomNames(arr) {
  return [
    arr[Math.floor(Math.random() * arr.length)],
    arr[Math.floor(Math.random() * arr.length)],
  ];
}

// Filling an array function
function arrFill(size) {
  var arr = [];
  var name;
  for (var i = 0; i < size; i++) {
    name = prompt("Enter name #" + [i + 1] + " : ");
    while (name == null || name == "" || !isNaN(name))
      name = prompt("Please Enter a Valid string for name #" + [i + 1] + " : ");
    arr.push(name);
  }
  return arr;
}

// Main
var size = Number(prompt("Enter the size of the array: (at least 2): "));
while (isNaN(size) || size < 2)
  size = Number(
    prompt("Please Enter a Valid number for the size of the array: ")
  );
var names = arrFill(size);
alert(randomNames(names));
