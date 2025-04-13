/*
	Check lower case or not
*/

let str1 = "hello world!";
let str2 = "Hello World!";

function lowerCaseCheck(str) {
  return str === str.toLowerCase();
}

console.log(`Is the string_1 lower cased? A: ${lowerCaseCheck(str1)}`);
console.log(`Is the string_2 lower cased? A: ${lowerCaseCheck(str2)}`);
