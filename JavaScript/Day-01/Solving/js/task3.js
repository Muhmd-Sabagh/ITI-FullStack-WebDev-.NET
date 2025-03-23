/*
A script that take a number from the user,
checks if the given number is divided by 3 only (return FIZZ),
divided by 5 only (return BUZZ) or both (return FIZZBUZZ),
or none of both numbers (return none).
*/

var number;

do {
	number = Number(prompt("Enter a number (or 0 to Exit): "));
	if (isNaN(number)) {
		alert("Please enter a valid number!");
		continue;
	} else if (number == 0)
		break;
	number%3 == 0 && number%5 ==0 ? alert("FIZZBUZZ") :
	number%3 == 0 ? alert("FIZZ") :
	number%5 == 0 ? alert("BUZZ") :
	alert("NONE");
} while (number != 0);

document.writeln("<h1>Thenks for using our script!</h1>");