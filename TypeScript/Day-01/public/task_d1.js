"use strict";
// 1- Define an array with string and number values only
let arr = [];
/**
 * 2- Write a function that accept an array of numbers or string
 * 		If all values are numbers -- return the sum
 * 		If all values are string -- return all values as a one string
 * 		If all values string or numbers -- return numbers only and sort them
 */
function strNumOperations(arr) {
    if (arr.every((item) => typeof item === "number")) {
        return arr.reduce((a, b) => a + b);
    }
    if (arr.every((item) => typeof item === "string")) {
        return arr.join(" ");
    }
    return arr
        .filter((item) => typeof item === "number")
        .sort()
        .reduce((a, b) => a + b);
}
console.log(strNumOperations(["Muhammad", 2, 3, 5, 6, "Ali"]));
// 3- Create abstract class Shape , rectangle , circle extends from area ...
class Shape {
    constructor(dim1, dim2) {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
}
class Rectangle extends Shape {
    constructor(width, height) {
        super(width, height);
    }
    area(width, height) {
        return width * height;
    }
}
class Circle extends Shape {
    constructor(radius) {
        super(radius);
    }
    area(radius) {
        return Math.PI * radius * radius;
    }
}
let rect = new Rectangle(10, 20);
let circle = new Circle(10);
console.log(`Rectangle area: ${rect.area(10, 20)}`);
console.log(`Circle area: ${circle.area(10)}`);
class Employee {
    constructor(id, fname, lname, age, salary, city, street, zCode) {
        this.id = id;
        this.fname = fname;
        this.lname = lname;
        this.age = age;
        this.salary = salary;
        this.address = { city, street, zCode };
    }
    get Salary() {
        return this.salary;
    }
}
class Manager extends Employee {
    constructor(employee) {
        super(employee.id, employee.fname, employee.lname, employee.age, employee.salary, employee.address.city, employee.address.street, employee.address.zCode);
    }
    showManagerData() {
        return `Manager Data:
	Manager Id: ${this.id}
	Manager Name: ${this.fname} ${this.lname}
	Manager Age: ${this.age}
	Manager Salary: ${this.Salary}
	Manager Address:
		City: ${this.address.city}
		Street: ${this.address.street}
		zCode: ${this.address.zCode}`;
    }
}
let emp = new Employee(1, "Muhammad", "Abdullah", 26, 10000, "Menoufia", "Anwar El-Sadat", 12345);
let manager = new Manager(emp);
console.log(manager.showManagerData());
// 5- enum -- week days -- create function (day)==> {if(this day is a weekend or not)}
var weekDays;
(function (weekDays) {
    weekDays[weekDays["Saturday"] = 0] = "Saturday";
    weekDays[weekDays["Sunday"] = 1] = "Sunday";
    weekDays[weekDays["Monday"] = 2] = "Monday";
    weekDays[weekDays["Tuesday"] = 3] = "Tuesday";
    weekDays[weekDays["Wednesday"] = 4] = "Wednesday";
    weekDays[weekDays["Thursday"] = 5] = "Thursday";
    weekDays[weekDays["Friday"] = 6] = "Friday";
})(weekDays || (weekDays = {}));
function isWeekend(day) {
    return day === weekDays.Friday || day === weekDays.Saturday;
}
console.log(`Is Today is a Weekend? ${isWeekend((new Date().getDay() + 8) % 7)}`);
