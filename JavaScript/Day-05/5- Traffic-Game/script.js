var lights = document.querySelectorAll(".light");
var statusText = document.querySelector(".status");
var states = ["STOP", "STEADY", "GO"];

var currentState = 0;

setTimeout(changeLight, 1000);

// Start the traffic game
function changeLight() {
  lights.forEach(function (light) {
    light.classList.remove("active");
  });

  lights[currentState].classList.add("active");

  statusText.textContent = states[currentState];

  currentState = (currentState + 1) % states.length;

  setTimeout(changeLight, 1000);
}
