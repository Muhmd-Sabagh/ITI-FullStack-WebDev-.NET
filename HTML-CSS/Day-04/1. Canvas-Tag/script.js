// DOM Elements
var canvas = document.getElementById("canvas");
var context = canvas.getContext("2d");
var color = document.getElementById("color-in");
var btn = document.getElementById("generate-btn");

// On btn click event
btn.addEventListener("click", function () {
  if (colorChanged) {
    context.clearRect(0, 0, canvas.width, canvas.height);
    generateCircles();
    colorChanged = false;
  } else generateCircles();
});

var colorChanged = false;
// Color change event
color.addEventListener("change", function () {
  colorChanged = true;
});

// Circles generate function
function generateCircles() {
  var numOfCircles = Math.floor(Math.random() * 50 + 1);
  var randomX;
  var randomY;
  for (var i = 0; i < numOfCircles; i++) {
    context.beginPath();
    randomX = Math.floor(Math.random() * (680 - 20 + 1)) + 20;
    randomY = Math.floor(Math.random() * (480 - 20 + 1)) + 20;
    context.strokeStyle = `${color.value}`;
    context.lineWidth = "2";
    context.arc(randomX, randomY, 20, 0, Math.PI * 2);
    context.stroke();
  }
}
