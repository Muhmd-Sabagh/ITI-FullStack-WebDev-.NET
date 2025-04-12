var numOfBooks = 0;
// validate the number of books
function validateNumOfBooks() {
  numOfBooks = document.getElementById("books-num").value;
  var isValid = numOfBooks >= 1;
  showError("books-num-error", !isValid);
  return isValid;
}

// Show error message function
function showError(elementId, show) {
  var errorElement = document.getElementById(elementId);
  errorElement.style.display = show ? "block" : "none";
}

// Save the num of books in the browser local storage
function saveNumOfBooks() {
  localStorage.setItem("books-num", numOfBooks);
}

var okBtn = document.getElementById("ok-btn");
// Go to add books page
function addBooks() {
  if (validateNumOfBooks()) {
    saveNumOfBooks();
    location.replace("books-add.html");
  } else {
    alert("Please fix the errors before submit.");
  }
}
