/*
	Return the positive numbers in an array of numbers
*/

let numbers = [5, 3, -8, 9, -7, -1, 0, -2];

function positiveNums(numbers) {
  return numbers.filter((num) => num > 0);
}

console.log(`Positive numbers is the array: ${positiveNums(numbers)}`);
