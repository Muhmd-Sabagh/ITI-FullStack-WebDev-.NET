/*
	Capitalize each element in an array of strings
*/

let names = ["muhammad", "ibrahim", "mustafa", "moamen"];

function capitalizeElements(array) {
  return array.map(
    (element) => element.charAt(0).toUpperCase() + element.slice(1)
  );
}

console.log(`Elements Capitaliized: ${capitalizeElements(names)}`);
