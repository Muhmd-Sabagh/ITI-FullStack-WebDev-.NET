/*
A function applyOperation that takes two numbers and a function as parameters.
applyOperation should call the passedin function with the two numbers
and return the result.
Test it by passing different operations like addition and multiplication.
*/

// Apply Operations Function
function applyOperation(n1, n2, operation) {
  return operation(n1, n2);
}

// Main
var add = function (n1, n2) {
  return "(" + n1 + " + " + n2 + ") = " + (n1 + n2);
};

var subtract = function (n1, n2) {
  return "(" + n1 + " - " + n2 + ") = " + (n1 - n2);
};

var multiply = function (n1, n2) {
  return "(" + n1 + " * " + n2 + ") = " + n1 * n2;
};

var divide = function (n1, n2) {
  return n2 == 0
    ? "(" + n1 + " / " + n2 + ") Can not divide by zero!"
    : "(" + n1 + " / " + n2 + ") = " + n1 / n2;
};

var num1 = Number(prompt("Plese Enter the first number: "));
while (isNaN(num1))
  num1 = Number(prompt("Please enter a valid value for the first number: "));

var num2 = Number(prompt("Plese Enter the second number: "));
while (isNaN(num2))
  num2 = Number(prompt("Please enter a valid value for the second number: "));

document.writeln("<h3>" + applyOperation(num1, num2, add) + "</h3>");
document.writeln("<h3>" + applyOperation(num1, num2, subtract) + "</h3>");
document.writeln("<h3>" + applyOperation(num1, num2, multiply) + "</h3>");
document.writeln("<h3>" + applyOperation(num1, num2, divide) + "</h3>");
