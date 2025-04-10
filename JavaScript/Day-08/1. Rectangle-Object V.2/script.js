/*
	Create a Rectangle Object
	• has width and height properties.
	• has two methods for calculating its area and perimeter.
	• override toString() function to display a message declaring the width,
		height, area and perimeter of the created object.
	• counts numbers of created objects and class method to retrieve the counter.
*/

var Rectangle = (function () {
  var counter = 0;
  // Rectangle Constructor Function
  function Rectangle(width, height) {
    this.width = width;
    this.height = height;
    counter++;
  }

  // Rectangle Methods
  Rectangle.prototype.area = function () {
    return this.width * this.height;
  };

  Rectangle.prototype.perimeter = function () {
    return 2 * (this.width + this.height);
  };

  Rectangle.prototype.toString = function () {
    return `Width: ${this.width}, Height: ${
      this.height
    } \nArea: ${this.area()} \nPerimeter: ${this.perimeter()}`;
  };

  // Static Method to get the counter
  Rectangle.getCounter = function () {
    return counter;
  };

  return Rectangle;
})();

// Main
console.log(Rectangle.getCounter());

var rectangle = new Rectangle(10, 5);
console.log(rectangle.toString());
console.log(Rectangle.getCounter());

var rectangle = new Rectangle(15, 7);
console.log(rectangle.toString());
console.log(Rectangle.getCounter());
