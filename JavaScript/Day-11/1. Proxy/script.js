/*
	Proxy Object with validation
*/

// Validate object properties
let handler = {
  set(target, prop, value) {
    switch (prop) {
      case "name":
        if (typeof value !== "string" || value.length !== 7) {
          throw new Error("Name must be a string of exactly 7 characters");
        }
        break;

      case "address":
        if (typeof value !== "string") {
          throw new Error("Address must be a string value");
        }
        break;

      case "age":
        if (typeof value !== "number" || value < 25 || value > 60) {
          throw new Error("Age must be a number between 25 and 60");
        }
        break;

      default:
        throw new Error(`Cannot set unknown property "${prop}"`);
    }

    // If validation passes, set the value
    target[prop] = value;
  },

  get(target, prop) {
    if (!(prop in target))
      throw new Error(`Property ${prop} does not exist on the object.`);
    return target[prop];
  },
};

// Proxy Object
let person = new Proxy({}, handler);

// Test
try {
  // person.name = "Ahmed"; // Throws error
  person.name = "Muhamad"; // Valid
  person.age = 30; // Valid
  person.address = "Cairo"; // Valid

  // console.log(person.salary); // Throws error
  console.log(person.name); // Valid
  console.log(person.age); // Valid
  console.log(person.address); // Valid
} catch (error) {
  console.log(error);
}
