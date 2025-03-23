<<<<<<< HEAD
/*
Fill an array of 3 elements from the user,
and apply each of the following mathematical operations on it (+, *, /).
Format the output as shown:
	Sum of the 3 values num1+num2+num3 = sum
	Multiplication of the 3 values num1*num2*num3 = mul
	Division of the 3 values num1/num2/num3 = div
*/

// Sum of an array elements function
function add(arr) {
  var result = 0;
  for (var i = 0; i < arr.length; i++) result += arr[i];
  return result;
}

// Multiplication of an array elements function
function multiply(arr) {
  var result = 1;
  for (var i = 0; i < arr.length; i++) result *= arr[i];
  return result;
}

// Didvision of an array elements function
function divide(arr) {
  var result = arr[0];
  if (arr.length == 1) return result;
  else
    for (var i = 1; i < arr.length; i++)
      if (arr[i] == 0) return false;
      else result /= arr[i];
  return result;
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
var inputArr = arrFill(3);

document.writeln(
  "<h1 style='text-align: center;'>Adding, Multiplying and Dividing 3 Values</h1><hr>"
);
document.writeln(
  "<h3>Sum of the 3 values " +
    inputArr[0] +
    " + " +
    inputArr[1] +
    " + " +
    inputArr[2] +
    " = " +
    add(inputArr) +
    "</h3>"
);
document.writeln(
  "<h3>Multiplication of the 3 values " +
    inputArr[0] +
    " * " +
    inputArr[1] +
    " * " +
    inputArr[2] +
    " = " +
    multiply(inputArr) +
    "</h3>"
);
if (divide(inputArr))
  document.writeln(
    "<h3>Division of the 3 values " +
      inputArr[0] +
      " / " +
      inputArr[1] +
      " / " +
      inputArr[2] +
      " = " +
      divide(inputArr) +
      "</h3>"
  );
else document.writeln("<h3>Division unsuccessful, Can not divide by 0</h3>");
=======
/*
Fill an array of 3 elements from the user,
and apply each of the following mathematical operations on it (+, *, /).
Format the output as shown:
	Sum of the 3 values num1+num2+num3 = sum
	Multiplication of the 3 values num1*num2*num3 = mul
	Division of the 3 values num1/num2/num3 = div
*/

// Sum of an array elements function
function add(arr) {
  var result = 0;
  for (var i = 0; i < arr.length; i++) result += arr[i];
  return result;
}

// Multiplication of an array elements function
function multiply(arr) {
  var result = 1;
  for (var i = 0; i < arr.length; i++) result *= arr[i];
  return result;
}

// Didvision of an array elements function
function divide(arr) {
  var result = arr[0];
  if (arr.length == 1) return result;
  else
    for (var i = 1; i < arr.length; i++)
      if (arr[i] == 0) return false;
      else result /= arr[i];
  return result;
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
var inputArr = arrFill(3);

document.writeln(
  "<h1 style='text-align: center;'>Adding, Multiplying and Dividing 3 Values</h1><hr>"
);
document.writeln(
  "<h3>Sum of the 3 values " +
    inputArr[0] +
    " + " +
    inputArr[1] +
    " + " +
    inputArr[2] +
    " = " +
    add(inputArr) +
    "</h3>"
);
document.writeln(
  "<h3>Multiplication of the 3 values " +
    inputArr[0] +
    " * " +
    inputArr[1] +
    " * " +
    inputArr[2] +
    " = " +
    multiply(inputArr) +
    "</h3>"
);
if (divide(inputArr))
  document.writeln(
    "<h3>Division of the 3 values " +
      inputArr[0] +
      " / " +
      inputArr[1] +
      " / " +
      inputArr[2] +
      " = " +
      divide(inputArr) +
      "</h3>"
  );
else document.writeln("<h3>Division unsuccessful, Can not divide by 0</h3>");
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
