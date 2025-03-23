/*
Displaying the user message on the web page
using the different html heading tags (from <h1> to <h6>) using Loop
*/

document.writeln("<h1>Test Heading</h1><hr>");

var msg = prompt("Enter your name");
for (var i = 0; i < 6; i++) {
		document.writeln("<h" + (i+1) + "> Hello " + msg + "</h" + (i+1) + ">");
}