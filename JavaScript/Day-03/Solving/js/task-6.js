/*
An object named library with a books property that is an array of objects,
where each book has title, author, and year properties.
Write a function that logs the title of each book in the library.
*/

function logBooksTitle(library) {
  for (var i = 0; i < library.books.length; i++) {
    document.writeln(
      "<h3>Book #" + (i + 1) + " Title: " + library.books[i].title + "</h3>"
    );
  }
}

var library = {
  books: [
    {
      title: "The Silent Echo",
      author: "Eleanor Graves",
      year: 2021,
    },
    {
      title: "Shadows of Tomorrow",
      author: "Daniel Mercer",
      year: 2019,
    },
    {
      title: "Fragments of Eternity",
      author: "Sophia Laurent",
      year: 2023,
    },
  ],
};

logBooksTitle(library);
