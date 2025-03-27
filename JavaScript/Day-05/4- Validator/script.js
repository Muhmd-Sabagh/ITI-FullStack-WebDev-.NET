/*
	Registration Form Validation
*/

// Show/Hide error messages
function showError(elementId, show) {
  var errorElement = document.getElementById(elementId);
  errorElement.style.display = show ? "block" : "none";
}

// Validation functions
// Validate Name
function validateName() {
  var name = document.getElementById("name").value.trim();
  var isValid = name !== "";
  showError("name-error", !isValid);
  return isValid;
}

// Validate Email
function validateEmail() {
  var email = document.getElementById("email").value;
  var emailRegex = /^[a-z]+[a-z0-9]{2,}@[a-z]{3,}\.com$/i;
  var isValid = emailRegex.test(email);
  showError("email-error", !isValid);
  return isValid;
}

// Validate Password
function validatePassword() {
  var password = document.getElementById("pass").value;
  var isValid = password.length >= 8;
  showError("pass-error", !isValid);
  return isValid;
}

// Validate Gender
function validateGender() {
  var genderSelected =
    document.querySelector('input[name="gender"]:checked') !== null;
  showError("gender-error", !genderSelected);
  return genderSelected;
}

// Validate Sports
function validateSports() {
  var sportsChecked =
    document.querySelectorAll('input[name="sports"]:checked').length >= 2;
  showError("sports-error", !sportsChecked);
  return sportsChecked;
}

// Validate Country
function validateCountry() {
  var country = document.getElementById("country").value;
  var isValid = country !== "";
  showError("country-error", !isValid);
  return isValid;
}

// Form Submission
function validateForm() {
  if (
    validateName() &&
    validateEmail() &&
    validatePassword() &&
    validateGender() &&
    validateSports() &&
    validateCountry()
  ) {
    alert("Submission successful!");
  } else {
    alert("Please fix the errors before submit.");
  }
}

// Form Reset
function resetForm() {
  document.getElementById("name").value = "";
  document.getElementById("email").value = "";
  document.getElementById("pass").value = "";
  document.querySelectorAll('input[name="gender"]').forEach(function (radio) {
    radio.checked = false;
  });
  document
    .querySelectorAll('input[name="sports"]')
    .forEach(function (checkbox) {
      checkbox.checked = false;
    });
  document.getElementById("country").value = "";

  // Hide all error messages
  document.querySelectorAll(".error-message").forEach(function (error) {
    error.style.display = "none";
  });
}
