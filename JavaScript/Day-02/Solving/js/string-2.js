<<<<<<< HEAD
/*
A Function to determine whether the entered string is palindrome or not.
Requesting the string to be entered via prompt,
asking the user whether to consider case sensitivity of the entered string or not
via confirm, handling both cases in the script.

i.e. RADAR NOON MOOM are palindrome.

Note: raDaR is not a palindrome if user requested considering case of
entered string, it will be palindrome if user requested ignoring case
sensitivity.
*/

function checkPalindrome(str, sensitivity) {
  var palindrome = true;
  if (!sensitivity) str = str.toLowerCase();

  for (var i = 0, j = str.length - 1; i < str.length / 2; i++, j--)
    if (str[i] != str[j]) palindrome = false;

  return palindrome;
}

// Main
var inputStr;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

var sensConsider = confirm("Do you want to consider case sensitivity?");

checkPalindrome(inputStr, sensConsider)
  ? alert("Your String " + inputStr + " is Palindrome :)")
  : alert("Your String " + inputStr + " is not Palindrome :(");
=======
/*
A Function to determine whether the entered string is palindrome or not.
Requesting the string to be entered via prompt,
asking the user whether to consider case sensitivity of the entered string or not
via confirm, handling both cases in the script.

i.e. RADAR NOON MOOM are palindrome.

Note: raDaR is not a palindrome if user requested considering case of
entered string, it will be palindrome if user requested ignoring case
sensitivity.
*/

function checkPalindrome(str, sensitivity) {
  var palindrome = true;
  if (!sensitivity) str = str.toLowerCase();

  for (var i = 0, j = str.length - 1; i < str.length / 2; i++, j--)
    if (str[i] != str[j]) palindrome = false;

  return palindrome;
}

// Main
var inputStr;
do {
  inputStr = prompt("Please Enter a valid string message: ");
} while (inputStr == null || inputStr == "" || !isNaN(inputStr));

var sensConsider = confirm("Do you want to consider case sensitivity?");

checkPalindrome(inputStr, sensConsider)
  ? alert("Your String " + inputStr + " is Palindrome :)")
  : alert("Your String " + inputStr + " is not Palindrome :(");
>>>>>>> a9b7bec3ae9ffe66ace7ca5f825c2eee046168c2
