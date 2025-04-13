/*
	Return the elements with the specified length from an array
*/

let names = ["Khaled", "Muhammad", "Reem", "Hany", "Zaina", "Farida"];

function specificElements(strings, length) {
  return strings.filter((element) => element.length > length);
}

console.log(`Elements with specific length: ${specificElements(names, 4)}`);
