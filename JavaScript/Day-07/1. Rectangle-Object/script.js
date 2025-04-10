/*
	Create a Rectangle Object
	• has width and height properties.
	• has two methods for calculating its area and perimeter.
	• has displayInfo() function to display a message declaring the width,
		height, area and perimeter of the created object.
*/

// Rectangle Constructor Function
function Rectangle(width, height) {
  this.width = width;
  this.height = height;
}

Rectangle.prototype.area = function () {
  return this.width * this.height;
};

Rectangle.prototype.perimeter = function () {
  return 2 * (this.width + this.height);
};

Rectangle.prototype.displayInfo = function () {
  return `Width: ${this.width}, Height: ${
    this.height
  } \nArea: ${this.area()} \nPerimeter: ${this.perimeter()}`;
};

// Main
var rectangle = new Rectangle(10, 5);
console.log(rectangle.displayInfo());
