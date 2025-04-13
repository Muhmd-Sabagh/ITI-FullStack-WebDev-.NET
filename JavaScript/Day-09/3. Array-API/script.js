/*
	Using of Array API
*/

let fruits = ["apple", "strawberry", "banana", "orange", "mango"];

let iLikeFruits = fruits.map((element) => `I Like ${element}`);

console.log(`
	Q: Is every element is a string? A: ${fruits.every(
    (element) => typeof element === "string"
  )}
	Q: Is some of array elements start with 'a'? A: ${fruits.some((element) =>
    element.startsWith("a")
  )}
	Q: Elements that starts with 'b' or 's'. A: ${fruits.filter(
    (element) => element.startsWith("a") || element.startsWith("s")
  )}
	Q: Elements with (I Like) statement. A: ${iLikeFruits}
	Q: Using forEach with iLikeFruits. A: `);

iLikeFruits.forEach((element) => console.log(`\t\t${element}`));
