var title, price, authorName, authorEmail;
// Validation functions
function validateTitle() {
  title = document.getElementById("title").value.trim();
  var isValid = title !== "";
  showError("title-error", !isValid);
  return isValid;
}

function validatePrice() {
  price = document.getElementById("price").value;
  var isValid = price > 0;
  showError("price-error", !isValid);
  return isValid;
}

function validateAuthorName() {
  authorName = document.getElementById("author-name").value.trim();
  var isValid = authorName !== "";
  showError("author-name-error", !isValid);
  return isValid;
}

var emailRegex = /^[a-z0-9]+@[a-z0-9]+\.[a-z]+$/i;
function validateAuthorEmail() {
  authorEmail = document.getElementById("author-email").value;
  var isValid = emailRegex.test(authorEmail) && authorEmail !== "";
  showError("author-email-error", !isValid);
  return isValid;
}

// Show error message function
function showError(elementId, show) {
  var errorElement = document.getElementById(elementId);
  errorElement.style.display = show ? "block" : "none";
}

// Author Object
function Author(_name, _email) {
  this.name = _name;
  this.email = _email;
}

// Book Object
function Book(_title, _price, _author) {
  this.title = _title;
  this.price = _price;
  this.author = _author;
}

// For book tracking
var numOfBooks = Number(localStorage.getItem("books-num")) || 0;
var bookIndex = 1;

// Function to save the book info in the browser local storage
function saveBook() {
  var book = new Book(title, price, new Author(authorName, authorEmail));

  localStorage.setItem("book_" + bookIndex, JSON.stringify(book));

  var ids = JSON.parse(localStorage.getItem("books_ids") || "[]");
  ids.push("book_" + bookIndex);
  localStorage.setItem("books_ids", JSON.stringify(ids));

  bookIndex++;
}

localStorage.clear();
// Go to add books page
function validateAndAdd() {
  if (
    validateTitle() &&
    validatePrice() &&
    validateAuthorName() &&
    validateAuthorEmail() &&
    numOfBooks === 1
  ) {
    saveBook();
    location.replace("books-info.html");
  } else if (
    validateTitle() &&
    validatePrice() &&
    validateAuthorName() &&
    validateAuthorEmail() &&
    numOfBooks > 1
  ) {
    saveBook();
    resetForm();
    numOfBooks--;
  } else {
    alert("Please fix the errors before submit.");
  }
}

// Reset Form Function
function resetForm() {
  document.getElementById("title").value = "";
  document.getElementById("price").value = "";
  document.getElementById("author-name").value = "";
  document.getElementById("author-email").value = "";
  document.querySelectorAll(".error-message").forEach(function (error) {
    error.style.display = "none";
  });
}
