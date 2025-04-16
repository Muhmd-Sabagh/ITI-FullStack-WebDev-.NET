// Classes
// Shape Class
class Shape {
  constructor() {
    if (this.constructor == Shape) {
      throw new Error("Abstract classes can't be instantiated.");
    }
  }

  // Abstract method
  calcArea() {
    throw new Error("Abstract methods can't be called.");
  }
  calcPerimeter() {
    throw new Error("Abstract methods can't be called.");
  }

  // Override the toString() method
  toString() {
    throw new Error("Abstract methods can't be called.");
  }
}

// Rectangle Class
class Rectangle extends Shape {
  constructor(height, width) {
    super();
    this.height = height;
    this.width = width;
  }
  calcArea() {
    return this.height * this.width;
  }
  calcPerimeter() {
    return 2 * (this.height + this.width);
  }
  // Override the toString() method
  toString() {
    return `Rectangle:	height = ${this.height}, width = ${this.width}
				Area = ${this.calcArea()}, Perimeter = ${this.calcPerimeter()}`;
  }
}

// Square Class
class Square extends Shape {
  constructor(side) {
    super();
    this.side = side;
  }
  calcArea() {
    return this.side * this.side;
  }
  calcPerimeter() {
    return 4 * this.side;
  }
  // Override the toString() method
  toString() {
    return `Square:	side = ${this.side}
				Area = ${this.calcArea()}, Perimeter = ${this.calcPerimeter()}`;
  }
}

// Circle Class
class Circle extends Shape {
  constructor(radius) {
    super();
    this.radius = radius;
  }
  calcArea() {
    return Math.PI * this.radius * this.radius;
  }
  calcPerimeter() {
    return 2 * Math.PI * this.radius;
  }
  // Override the toString() method
  toString() {
    return `Circle:	radius = ${this.radius}
				Area = ${this.calcArea()}, Perimeter = ${this.calcPerimeter()}`;
  }
}

// Exporting
export { Shape, Rectangle, Square, Circle };
