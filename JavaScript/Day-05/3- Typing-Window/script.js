/*
	String Typing In A New Window
*/

var msg =
  "Lorem ipsum dolor sit amet consectetur adipisicing elit. quod ipsum doloremque quas quos.";

// Open the new window to show the message when btn clicked
function startShowMessage() {
  var newWindow = open("new-window.html", "", "width=400, height=200");

  setTimeout(function () {
    var msgContainer = newWindow.document.getElementById("message-container");
    var currentChar = 0;

    var myInterval = setInterval(function () {
      if (currentChar < msg.length) {
        // Start displaying the message
        msgContainer.innerHTML += msg.charAt(currentChar);
        currentChar++;
      } else {
        // Close the window after displaying completed
        clearInterval(myInterval);
        setTimeout(newWindow.close(), 2000);
      }
    }, 80);
  }, 500);
}
