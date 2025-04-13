/*
	Return Min and Max value in an array using rest param and spread operator
*/

let array = [1, 5, 3, 9, 2, 6, 10, 8, 4, 7];

function minMax(...numbers) {
  let min = numbers[0];
  let max = numbers[0];

  for (let i = 1; i < numbers.length; i++) {
    if (numbers[i] < min) min = numbers[i];
    else if (numbers[i] > max) max = numbers[i];
  }

  return [min, max];
}

let [min, max] = minMax(...array);
console.log(`Min: ${min}, Max: ${max}`);
