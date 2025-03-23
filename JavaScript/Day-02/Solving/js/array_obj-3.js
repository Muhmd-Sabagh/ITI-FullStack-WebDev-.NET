<<<<<<< HEAD
/*
A function that take a sentence
and a letter to search for it in the given sentence
and return its indexes
*/

function indecesOfLetter(str, letter) {
  var indeces = [];
  str = str.toLowerCase();
  letter = letter.toLowerCase();
  for (var i = 0; i < str.length; i++) if (str[i] === letter) indeces.push(i);
  return indeces;
}

// Main
var inputStr;
var inputLetter;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

do {
  inputLetter = prompt("Please Enter a letter to search for: ");
} while (
  inputLetter == null ||
  inputLetter == "" ||
  !isNaN(inputLetter) ||
  inputLetter.length > 1
);

if (inputStr.toLowerCase().indexOf(inputLetter.toLowerCase()) != -1)
  alert(
    "The letter '" +
      inputLetter +
      "' was found in the index(es) of: " +
      indecesOfLetter(inputStr, inputLetter)
  );
else
  alert(
    "The letter '" + inputLetter + "' was not found in the given sentence!"
  );
=======
/*
A function that take a sentence
and a letter to search for it in the given sentence
and return its indexes
*/

function indecesOfLetter(str, letter) {
  var indeces = [];
  str = str.toLowerCase();
  letter = letter.toLowerCase();
  for (var i = 0; i < str.length; i++) if (str[i] === letter) indeces.push(i);
  return indeces;
}

// Main
var inputStr;
var inputLetter;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

do {
  inputLetter = prompt("Please Enter a letter to search for: ");
} while (
  inputLetter == null ||
  inputLetter == "" ||
  !isNaN(inputLetter) ||
  inputLetter.length > 1
);

if (inputStr.toLowerCase().indexOf(inputLetter.toLowerCase()) != -1)
  alert(
    "The letter '" +
      inputLetter +
      "' was found in the index(es) of: " +
      indecesOfLetter(inputStr, inputLetter)
  );
else
  alert(
    "The letter '" + inputLetter + "' was not found in the given sentence!"
  );
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
