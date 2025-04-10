/*
	A box object that contains books objects, with ability of:
	a. count # of books inside box.
	b. delete any of these books in box according to book name or type.
	c. create book object and add it to box object content property
	d. use toString() to tell its dimensions and how many books are stored in it.
	e. implement valueof() so that if there is more than one box object we can
		 get total books in these boxes by adding the i.e. box1 has 5 books
		 while box2 has 2 books, box1 + box2 should return 7

	► box object has the following properties: height, width, length, numOfBooks, content.
		Where the content property contains an array of books.
	► book object has the following properties: type, title, author.
*/

// Book Constructor Function
function Book(type, title, author) {
  this.type = type;
  this.title = title;
  this.author = author;
}
Book.prototype.toString = function () {
  return `Book: ${this.title}, Type: ${this.type}, Author: ${this.author}`;
};

// Box Constructor Function
function Box(height, width, length, content) {
  this.height = height;
  this.width = width;
  this.length = length;
  this.numOfBooks = 0;
  this.content = content || [];
}

// Add book
Box.prototype.addBook = function (book) {
  this.content.push(book);
  this.numOfBooks++;
};

// Delete book by name or type
Box.prototype.deleteBook = function (bookNameOrType) {
  var books = this.content;
  var bookIndex;
  for (var i = 0; i < books.length; i++) {
    if (
      books[i] &&
      (books[i].title === bookNameOrType || books[i].type === bookNameOrType)
    ) {
      bookIndex = i;
    }
  }
  if (bookIndex !== undefined) {
    this.content.pop(bookIndex);
    this.numOfBooks--;
  } else {
    console.log("Book not found.");
  }
};

// Override toString method
Box.prototype.toString = function () {
  var booksStr = "";
  for (var i = 0; i < this.content.length; i++) {
    booksStr += this.content[i].toString() + "\n";
  }
  return `Box Dimensions: ${this.height} x ${this.width} x ${this.length}, Number of Books: ${this.numOfBooks} \nBooks: ${booksStr}`;
};

// Override valueOf method
Box.prototype.valueOf = function () {
  return this.numOfBooks;
};

// Test
var box1 = new Box(10, 20, 30);
var book1 = new Book("Fiction", "Palace Walk", "Naguib Mahfouz");
var book2 = new Book("Political", "The Open Door", "Latifa al-Zayyat");
box1.addBook(book1);
box1.addBook(book2);
console.log(box1.toString());
box1.deleteBook("Palace Walk");
console.log(box1.toString());
var box2 = new Box(15, 25, 35);
var book3 = new Book(
  "Historical ",
  "Cairo: The City Victorious",
  "Max Rodenbeck"
);
box2.addBook(book3);
console.log(box2.toString());
console.log(box1 + box2);
