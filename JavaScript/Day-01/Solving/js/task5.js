/*
A script that reads from the user his info,
validates and displays it with a welcoming message on the web page.
*/

// Reading the user's info
var username, phone, mobile, email, color;
document.writeln("<h1>Entering User Info...</h1><hr>");

// Username
do {
		username = prompt("Enter Your Name:");
		if (username == null || username == "" || !isNaN(username))
			alert("Please Enter a Valid Name!");
		else 
			break;
} while (true);

// Phone Number
do {
	phone = prompt("Enter Your Phone Number:");
	if (phone == null || phone == "" || isNaN(phone) || phone.length != 8)
		alert("Please Enter a Valid Phone Number!");
	else 
		break;
} while (true);

// Mobile Number
do {
	mobile = prompt("Enter Your Mobile Number:");
	// Without RegEx
	// if (mobile == null || mobile == "" || isNaN(mobile) || mobile.length != 11
	// 	|| mobile.charAt(0) != "0" || mobile.charAt(1) != "1"
	// 	|| (mobile.charAt(2) != "0" && mobile.charAt(2) != "1"
	// 	&& mobile.charAt(2) != "2" && mobile.charAt(2) != "5"))
	// With RegEx
	if (mobile == null || mobile == "" || isNaN(mobile) || mobile.length != 11
			||(mobile.search(/\b010/) == -1 && mobile.search(/\b011/) == -1
			&& mobile.search(/\b012/) == -1 && mobile.search(/\b015/) == -1))
		alert("Please Enter a Valid Mobile Number!");
	else 
		break;
} while (true);

// Email
do {
	email = prompt("Enter Your Email:");
	if (email == null || email == "" || email.search(/^[a-z]{3}@[0-9]{3}\.com$/i) == -1)
		alert("Please Enter a Valid Email!");
	else
		break;
} while (true);

// Color
do {
	color = prompt("Enter Your Favorite Color:");
	if (color == null || color == "" || color.search(/^[a-z]+$/i) == -1)
		alert("Please Enter a Valid Color!");
	else
		break;
} while (true);

document.writeln("<h3 style='color:" + color+ "'>Welcome " + username + "</h3>");
document.writeln("<h3 style='color:" + color+ "'>Your Phone Number is: " + phone + "</h3>");
document.writeln("<h3 style='color:" + color+ "'>Your Mobile Number is: " + mobile + "</h3>");
document.writeln("<h3 style='color:" + color+ "'>Your Email is: " + email.toLowerCase() + "</h3>");