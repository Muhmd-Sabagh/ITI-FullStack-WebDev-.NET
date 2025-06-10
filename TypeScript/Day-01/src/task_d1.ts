// 1- Define an array with string and number values only
let arr: (string | number)[] = [];

/**
 * 2- Write a function that accept an array of numbers or string
 * 		If all values are numbers -- return the sum
 * 		If all values are string -- return all values as a one string
 * 		If all values string or numbers -- return numbers only and sort them
 */
function strNumOperations(arr: (string | number)[]): string | number {
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
abstract class Shape {
  constructor(protected dim1: number, protected dim2?: number) {}
  abstract area(dim1: number, dim2?: number): number;
}

class Rectangle extends Shape {
  constructor(width: number, height: number) {
    super(width, height);
  }

  override area(width: number, height: number): number {
    return width * height;
  }
}

class Circle extends Shape {
  constructor(radius: number) {
    super(radius);
  }

  override area(radius: number): number {
    return Math.PI * radius * radius;
  }
}

let rect = new Rectangle(10, 20);
let circle = new Circle(10);
console.log(`Rectangle area: ${rect.area(10, 20)}`);
console.log(`Circle area: ${circle.area(10)}`);

/**
 * 4- Create Interface IEmplyee id,fname,lname,age,salary,address:{city,street,zCode}
 * 		Create class Employee Implement IEmplyee -- getSalary
 * 		Create class Manager extened Employee -- show Employee Data (empId){show emp data};
 */
interface IEmplyee {
  id: number;
  fname: string;
  lname: string;
  age: number;
  salary: number;
  address: {
    city: string;
    street: string;
    zCode: number;
  };
}

class Employee implements IEmplyee {
  id: number;
  fname: string;
  lname: string;
  age: number;
  salary: number;
  address: { city: string; street: string; zCode: number };

  constructor(
    id: number,
    fname: string,
    lname: string,
    age: number,
    salary: number,
    city: string,
    street: string,
    zCode: number
  ) {
    this.id = id;
    this.fname = fname;
    this.lname = lname;
    this.age = age;
    this.salary = salary;
    this.address = { city, street, zCode };
  }

  get Salary(): number {
    return this.salary;
  }
}

class Manager extends Employee {
  constructor(employee: Employee) {
    super(
      employee.id,
      employee.fname,
      employee.lname,
      employee.age,
      employee.salary,
      employee.address.city,
      employee.address.street,
      employee.address.zCode
    );
  }
  showManagerData(): string {
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

let emp = new Employee(
  1,
  "Muhammad",
  "Abdullah",
  26,
  10000,
  "Menoufia",
  "Anwar El-Sadat",
  12345
);
let manager = new Manager(emp);
console.log(manager.showManagerData());

// 5- enum -- week days -- create function (day)==> {if(this day is a weekend or not)}
enum weekDays {
  Saturday,
  Sunday,
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
}

function isWeekend(day: weekDays): boolean {
  return day === weekDays.Friday || day === weekDays.Saturday;
}

console.log(
  `Is Today is a Weekend? ${isWeekend((new Date().getDay() + 8) % 7)}`
);
