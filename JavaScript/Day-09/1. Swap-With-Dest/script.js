/*
	Swap two values with destructuring
*/

let value_1 = 5;
let value_2 = 10;

[value_1, value_2] = [value_2, value_1];

console.log(`Value_1: ${value_1}\nValue_2: ${value_2}`);
