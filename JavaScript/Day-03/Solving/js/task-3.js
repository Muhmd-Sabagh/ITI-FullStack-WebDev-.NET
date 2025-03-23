<<<<<<< HEAD
/*
A JavaScript function which will take an array of numbers
stored and find the second lowest and second greatest numbers.
*/

// Second Lowest and Second Greatest function
function secondLowestAndGreatest(arr) {
  var sortedArr = arr.sort((a, b) => a - b);

  // Find the second lowest and skip duplicates
  var i = 1;
  var secondLowest;
  do {
    secondLowest = sortedArr[i];
    i++;
  } while (secondLowest === sortedArr[i - 2] && i < sortedArr.length);

  // Find the second greatest and skip duplicates
  i = sortedArr.length - 2;
  var secondGreatest;
  do {
    secondGreatest = sortedArr[i];
    i--;
  } while (secondGreatest === sortedArr[i + 2] && i >= 0);

  return [secondLowest, secondGreatest];
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
var size = Number(prompt("Enter the size of the array: (at least 2): "));
while (isNaN(size) || size < 2)
  size = Number(
    prompt("Please Enter a Valid number for the size of the array: ")
  );

alert(secondLowestAndGreatest(arrFill(size)));
=======
/*
A JavaScript function which will take an array of numbers
stored and find the second lowest and second greatest numbers.
*/

// Second Lowest and Second Greatest function
function secondLowestAndGreatest(arr) {
  var sortedArr = arr.sort((a, b) => a - b);

  // Find the second lowest and skip duplicates
  var i = 1;
  var secondLowest;
  do {
    secondLowest = sortedArr[i];
    i++;
  } while (secondLowest === sortedArr[i - 2] && i < sortedArr.length);

  // Find the second greatest and skip duplicates
  i = sortedArr.length - 2;
  var secondGreatest;
  do {
    secondGreatest = sortedArr[i];
    i--;
  } while (secondGreatest === sortedArr[i + 2] && i >= 0);

  return [secondLowest, secondGreatest];
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
var size = Number(prompt("Enter the size of the array: (at least 2): "));
while (isNaN(size) || size < 2)
  size = Number(
    prompt("Please Enter a Valid number for the size of the array: ")
  );

alert(secondLowestAndGreatest(arrFill(size)));
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
