<<<<<<< HEAD
/*
A Function that accepts a string from user through prompt
and count the number of ‘e’ characters in it.
*/

function occurenceOfChar(str, char) {
  var count = 0;
  for (var i = 0; i < str.length; i++) if (str[i] === char) count++;
  return count;
}

// Main
var inputStr;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

alert(
  "The char 'e' occures " +
    occurenceOfChar(inputStr, "e") +
    " time(s) in your string."
);
=======
/*
A Function that accepts a string from user through prompt
and count the number of ‘e’ characters in it.
*/

function occurenceOfChar(str, char) {
  var count = 0;
  for (var i = 0; i < str.length; i++) if (str[i] === char) count++;
  return count;
}

// Main
var inputStr;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

alert(
  "The char 'e' occures " +
    occurenceOfChar(inputStr, "e") +
    " time(s) in your string."
);
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
