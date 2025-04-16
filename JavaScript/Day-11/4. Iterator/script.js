/*
	Iterable Object
*/

let student = {
  id: 1,
  name: "Ali Elsayed",
  age: 25,
  address: "Menoufia",
};

let employee = {
  id: 1,
  name: "Ahmed Khaled",
  age: 30,
  salay: 5000,
  hours: 8,
};

// Iterator Function
let iterator = function () {
  let keys = Object.keys(this);
  index = 0;
  return {
    next: () => {
      // index++;
      if (index < keys.length) {
        return { value: this[keys[index++]], done: false };
      } else return { done: true };
    },
  };
};

// Using of Iterator Function
student[Symbol.iterator] = iterator;

for (let value of student) {
  console.log(value);
}

// Before Iterator
try {
  for (let value of employee) {
    console.log(value);
  }
} catch (error) {
  console.log(error);
}

// After Iterable
employee[Symbol.iterator] = iterator;
for (let value of employee) {
  console.log(value);
}
