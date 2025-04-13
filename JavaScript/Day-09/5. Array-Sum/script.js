/*
	Sum of array elements using reduce()
*/

let numbers = [1, 5, 3, 9, 2, 6, 10, 8, 4, 7];

function sumOfElements(array) {
  return array.reduce((acc, element) => acc + element);
}

console.log(`Sum of array Elements = ${sumOfElements(numbers)}`);
