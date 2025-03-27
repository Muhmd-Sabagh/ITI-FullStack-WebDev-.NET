// Cookies Functions
function setCookie(name, value, days) {
  var date = new Date();
  date.setDate(date.getDate() + days);
  document.cookie = name + "=" + value + "; expires=" + date;
}

function getCookie(name) {
  var nameEQ = name + "=";
  var cookies = document.cookie.split(";");
  for (var i = 0; i < cookies.length; i++) {
    var cookie = cookies[i];
    while (cookie.charAt(0) == " ") {
      cookie = cookie.substring(1);
    }
    if (cookie.indexOf(nameEQ) == 0) {
      return cookie.substring(nameEQ.length);
    }
  }
  return null;
}

function deleteCookie(name) {
  document.cookie = name + "=; expires=Thu, 01 Jan 1970 00:00:00 GMT";
}

function hasCookie(name) {
  return getCookie(name) != null;
}

function saveCookies() {
  setCookie("username", username, 30);
  setCookie("age", age, 30);
  setCookie("gender", gender.value, 30);
  setCookie("color", color, 30);
}

// Validation Functions
var username, age, gender, color;

function showError(elementId, show) {
  var errorElement = document.getElementById(elementId);
  errorElement.style.display = show ? "block" : "none";
}

function validateName() {
  username = document.getElementById("name").value.trim();
  var isValid = username !== "";
  showError("name-error", !isValid);
  return isValid;
}

function validateAge() {
  age = document.getElementById("age").value;
  var isValid = age >= 10;
  showError("age-error", !isValid);
  return isValid;
}

function validateGender() {
  gender = document.querySelector('input[name="gender"]:checked');
  var isValid = gender !== null;
  showError("gender-error", !isValid);
  return isValid;
}

function validateColor() {
  color = document.getElementById("fav-color").value;
  var isValid = color !== "";
  showError("color-error", !isValid);
  return isValid;
}

function visit() {
  if (validateName() & validateAge() & validateGender() & validateColor()) {
    saveCookies();
    location.replace("our-website.html");
  } else {
    alert("Please fix the errors before submit.");
  }
}

function resetForm() {
  document.getElementById("name").value = "";
  document.getElementById("age").value = "";
  document.querySelectorAll('input[name="gender"]').forEach(function (radio) {
    radio.checked = false;
  });
  document.getElementById("fav-color").value = "";
  document.querySelectorAll(".error-message").forEach(function (error) {
    error.style.display = "none";
  });
}

// var visitCount = 1;
// Profile Page Code
function displayProfile() {
  if (!hasCookie("username")) {
    location.replace("index.html");
    return;
  }

  var username = getCookie("username");
  var gender = getCookie("gender");
  var color = getCookie("color");
  var visits = trackVisit();

  var profileImg = gender === "male" ? "images/1.jpg" : "images/2.jpg";
  document.getElementById("profile-container").innerHTML =
    "<img src='" +
    profileImg +
    "' alt='Profile Picture'>" +
    "<h2>Welcome <span style='color: " +
    color +
    ";'>" +
    username +
    "</span>" +
    " You have visited this site <span style='color: " +
    color +
    ";'>" +
    visits +
    "</span> time(s) :)";
}

// Visit counter function
function trackVisit() {
  var visitCount = Number(getCookie("visitCount")) || 0;
  visitCount++;
  setCookie("visitCount", visitCount, 30);
  return visitCount;
}
