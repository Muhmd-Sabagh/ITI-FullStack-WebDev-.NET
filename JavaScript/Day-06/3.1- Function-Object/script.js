/*
	A function that accepts only 2 parameters and throw exception
	if number of parameters either less than or exceeds 2 parameters.
*/

function justTwoParams(param1, param2) {
  if (arguments.length < 2 || arguments.length > 2)
    throw "You must provide 2 parameters not more or less!";

  return (
    "Function called successfully with (" + param1 + " and " + param2 + ")"
  );
}

// Main
try {
  console.log(justTwoParams("a", "b"));
} catch (error) {
  console.log(error);
}
try {
  console.log(justTwoParams("a", "b", "c"));
} catch (error) {
  console.log(error);
}
try {
  console.log(justTwoParams("a"));
} catch (error) {
  console.log(error);
}
