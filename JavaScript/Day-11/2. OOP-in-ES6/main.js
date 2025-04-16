/*
	different shapes (rectangle, square, circle)
	make all of them inherits from shape class.
 */

// Modules
import { Rectangle, Square, Circle } from "./shapes.js";

// Testing
let rect = new Rectangle(10, 20);
let square = new Square(7);
let circle = new Circle(5);

// Print
console.log(rect.toString());
console.log(square.toString());
console.log(circle.toString());
