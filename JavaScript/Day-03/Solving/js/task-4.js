/*
A JavaScript function that accepts a string as a parameter and
converts the first letter of each word of the string in upper case.
*/

function capitalizeFirstLetter(str) {
  return str.replace(/\b[a-z]/g, function (letter) {
    return letter.toUpperCase();
  });
}

// Main
var str = prompt("Enter a string message: ");
while (str === "" || str === null || !isNaN(str)) {
  str = prompt("Please enter a valid string message: ");
}

alert(capitalizeFirstLetter(str));
