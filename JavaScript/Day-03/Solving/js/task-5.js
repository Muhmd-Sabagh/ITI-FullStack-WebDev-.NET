/*
A function that takes an object as an argument and
prints all key-value pairs.
Test it by passing the student object.
*/

// Print object values function
function printObjectValues(obj) {
  for (var key in obj) {
    if (typeof obj[key] === "object") {
      document.writeln(key + ":<br>");
      printObjectValues(obj[key]);
    } else document.writeln(key + ": " + obj[key] + "<br>");
  }
}

// Main
var student = {
  name: "Ali Elsayed",
  age: 25,
  grades: {
    math: 90,
    science: 85,
    literature: 88,
  },
  contactInfo: {
    email: "alielsayed@example.com",
    phone: "01012345678",
  },
};

printObjectValues(student);
