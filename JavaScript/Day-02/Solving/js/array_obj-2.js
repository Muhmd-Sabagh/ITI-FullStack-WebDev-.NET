/*
Fill an array (5 numerical values) from the user,
Sort it in descending and ascending orders,
then display the output as shown:
	You have entered the values: n3, n1, n4, n2, n5
	Your values after being sorted Descending: n5, n4, n3, n2, n1
	Your values after being sorted Ascending: n1, n2, n3, n4, n5
*/

// Descending Sort Function
function descendingSort(arr) {
  var temp;
  for (var i = 0; i < arr.length - 1; i++)
    for (var j = 0; j < arr.length - i - 1; j++)
      if (arr[j] < arr[j + 1]) {
        temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
  return arr;
}

// Ascending Sort Function
function ascendingSort(arr) {
  var temp;
  for (var i = 0; i < arr.length - 1; i++)
    for (var j = 0; j < arr.length - i - 1; j++)
      if (arr[j] > arr[j + 1]) {
        temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
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
var inputArr = arrFill(5);
document.writeln("<h1 style='text-align: center;'>Sorting</h1><hr>");
document.writeln("<h3>You have entered the values: " + inputArr + "</h3>");

// Without the built in sort() function
document.writeln(
  "<h2>Sorting without using of the built in sort function</h2>"
);
document.writeln(
  "<h3 style='color=red;'>Your values after being sorted Descending: " +
    descendingSort(inputArr) +
    "</h3>"
);
document.writeln(
  "<h3 style='color=red;'>Your values after being sorted Ascending : " +
    ascendingSort(inputArr) +
    "</h3>"
);

// With the built in sort() function
document.writeln("<br><h2>Sorting with the built in sort function</h2>");
document.writeln(
  "<h3 style='color=blue'>Your values after being sorted Descending: " +
    inputArr.sort((a, b) => b - a) +
    "</h3>"
);
document.writeln(
  "<h3 style='color=blue'>Your values after being sorted Ascending: " +
    inputArr.sort((a, b) => a - b) +
    "</h3>"
);
