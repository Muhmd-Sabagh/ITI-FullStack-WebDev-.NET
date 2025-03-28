/*
	A function that adds n numbers only.
	Throw exception if the user passed any data type other than 'number'
	or called your function without passing any parameters.
*/

function addNumbers() {
  // Check if no arguments were passed
  if (arguments.length === 0) {
    throw "No parameters provided!";
  }

  var sum = 0;

  // Validate each parameter
  for (var i = 0; i < arguments.length; i++) {
    if (typeof arguments[i] !== "number" || isNaN(arguments[i])) {
      throw `Invalid parameter at position ${i + 1} - It must be a number`;
    }
    sum += arguments[i];
  }

  return sum;
}

// Main
try {
  console.log(addNumbers(1, 2, 3));
  console.log(addNumbers(10, 20, 30, 40));
  console.log(addNumbers(50));
  console.log(addNumbers());
  console.log(addNumbers(1, "2", 3));
  console.log(addNumbers(1, 2, null));
} catch (error) {
  console.log(error);
}
