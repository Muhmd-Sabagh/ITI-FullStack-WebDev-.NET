/*
	Rectangle object that inherits from Shape Constructor,
	and Square constructor that inherits from Rectangle.
	• Prevent creating any object from shape, allow creation of only rectangles and square

	Bonus: allow creation of only one square and one rectangle.
*/

// Shape Constructor Function
function Shape(dim1, dim2) {
  if (this.constructor === Shape) {
    throw "Cannot create instance of abstract class Shape";
  }
  this.dim1 = dim1;
  this.dim2 = dim2;
}

Shape.prototype.area = function () {
  return this.dim1 * this.dim2;
};

Shape.prototype.perimeter = function () {
  return 2 * (this.dim1 + this.dim2);
};

Shape.prototype.toString = function () {
  return `Dim1: ${this.dim1}, Dim2: ${
    this.dim2
  } \nArea: ${this.area()} \nPerimeter: ${this.perimeter()}`;
};

// Rectangle Constructor Function
function Rectangle(width, height) {
  Shape.call(this, width, height); // 1
  if (Rectangle.instance && this.constructor === Rectangle) {
    throw "Cannot create more than one instance of Rectangle";
  }
  Rectangle.instance = this;
}
Rectangle.prototype = Object.create(Shape.prototype); // 2
Rectangle.prototype.constructor = Rectangle; // 3

// Overriding toString method
Rectangle.prototype.toString = function () {
  return `Rectangle: \nWidth: ${this.dim1}, Height: ${
    this.dim2
  } \nArea: ${this.area()} \nPerimeter: ${this.perimeter()}`;
};

// Square Constructor Function
function Square(side) {
  Rectangle.call(this, side, side); // 1
  if (Square.instance && this.constructor === Square) {
    throw "Cannot create more than one instance of Square";
  }
  Square.instance = this;
}
Square.prototype = Object.create(Rectangle.prototype); // 2
Square.prototype.constructor = Square; // 3

// Overriding toString method
Square.prototype.toString = function () {
  return `Square: \nSide: ${
    this.dim1
  } \nArea: ${this.area()} \nPerimeter: ${this.perimeter()}`;
};

// Main
try {
  var shape = new Shape(10, 5);
  console.log(shape.toString());
} catch (e) {
  console.log(e);
}

try {
  var rectangle = new Rectangle(10, 5);
  console.log(rectangle);
  console.log(rectangle.toString());
} catch (e) {
  console.log(e);
}

try {
  var rectangle2 = new Rectangle(20, 10);
  console.log(rectangle2.toString());
} catch (e) {
  console.log(e);
}

try {
  var square = new Square(5);
  console.log(square.toString());
} catch (e) {
  console.log(e);
}

try {
  var square2 = new Square(5);
  console.log(square2.toString());
} catch (e) {
  console.log(e);
}
