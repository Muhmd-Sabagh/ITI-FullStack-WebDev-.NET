/*
Write a script that ask the user to
• Enter the value of a circle’s radius in order to calculate its area and alert the result
• Enter another value to calculate its square root and alert the result
• Enter an angle to calculate its cos value then alert the result
*/

// Circle Area
var radius = Number(prompt("Enter the value of a circle's radius: "));
while (isNaN(radius))
  radius = Number(prompt("Please Enter a Valid number for the radius: "));
alert("The area of the circle is: " + Math.PI * radius * radius);

// Square Root
var num = Number(prompt("Enter a value to calculate its square root: "));
while (isNaN(num))
  num = Number(prompt("Please Enter a Valid number for the value: "));
alert("The square root of the value is: " + Math.sqrt(num));

// Cos Value
var angle = Number(prompt("Enter an angle to calculate its cos value: "));
while (isNaN(angle))
  angle = Number(prompt("Please Enter a Valid number for the angle: "));
alert(
  "The cos value of the angle " +
    angle +
    " is: " +
    Math.cos((angle * Math.PI) / 180).toFixed(2)
);
