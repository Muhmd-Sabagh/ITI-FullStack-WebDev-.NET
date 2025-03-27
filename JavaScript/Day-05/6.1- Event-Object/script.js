/*
	Alert ASCII Code of any key pressed and
	detect whether it is alt key or ctrl key or shift key
*/

// Adding the Event to the document
document.addEventListener("keydown", function (e) {
  var key = e.key;
  var asciiCode = key.charCodeAt(0);

  alert(
    `${
      e.altKey
        ? "Alt Key Pressed!\nASCII Code: 18"
        : e.ctrlKey
        ? "Shift Key Pressed!\nASCII Code: 17"
        : e.shiftKey
        ? "Shift Key Pressed!\nASCII Code: 16"
        : `Key: ${key}\nASCII Code: ${asciiCode}`
    }`
  );
});
