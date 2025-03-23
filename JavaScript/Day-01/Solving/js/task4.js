/*
Who am I game
*/

if(confirm("Welcome to the 'Who am I?' game!\nDo you want to play?")) {
	if (confirm("Do You Fly?"))
		if (confirm("Are You Wild?"))
			document.writeln("<img src='images/eagle.png'><br>You are an Eagle!<hr>");
		else
			document.writeln("<img src='images/parrot.png'><br>You are a Parrot!<hr>");
	else
		if (confirm("Do You Live Undersea?"))
			if (confirm("Are You Wild?"))
				document.writeln("<img src='images/shark.png'><br>You are a Shark!<hr>");
			else
				document.writeln("<img src='images/dolphin.png'><br>You are a Dolphin!<hr>");
		else
			if (confirm("Are You Wild?"))
				document.writeln("<img src='images/lion.png'><br>You are a Lion!<hr>");
			else
				document.writeln("<img src='images/cat.png'><br>You are a Cat!<hr>");
}

document.writeln("<h1>Thanks for using our script!</h1>");