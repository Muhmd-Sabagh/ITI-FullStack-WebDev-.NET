/*
	Alert ASCII Code of any key pressed and
	detect whether it is alt key or ctrl key or shift key
*/

// Adding the Event to the document
document.addEventListener("keydown", function (e) {
  var key = e.key;
  var asciiCode = key.charCodeAt(0);

  alert(`Key: ${key}\nASCII Code: ${asciiCode}`);
});
