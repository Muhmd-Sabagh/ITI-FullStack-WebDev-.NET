/*
A script that takes from the user n values and returns their sum,
stop receiving values from user when he enters 0 or sum exceeds 100,
check that the entered data is numeric,
inform the user with the total sum of the entered values.
*/
var num;
var sum = 0;

do {
		num = Number(prompt("Enter a number: "));
		if (isNaN(num)) {
			alert("Please enter a valid number!");
			continue;
		}
		sum += num;
} while (num != 0 && sum <= 100);

alert("The sum of the entered values is: " + sum);
document.writeln("<h1>Thank you for using our script!</h1>");