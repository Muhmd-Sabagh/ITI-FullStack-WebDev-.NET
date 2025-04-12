// On window load, fill the table with books info
window.onload = function () {
  var tableBody = document.querySelector("#books-table-body");
  var ids = JSON.parse(localStorage.getItem("books_ids") || "[]");

  ids.forEach(function (id) {
    var book = JSON.parse(localStorage.getItem(id));
    if (book) {
      var row = document.createElement("tr");
      row.innerHTML = `
        <td><input type="text" value="${book.title}" disabled></td>
        <td><input type="number" value="${book.price}" disabled></td>
        <td><input type="text" value="${book.author.name}" disabled></td>
        <td><input type="text" value="${book.author.email}" disabled></td>
        <td>
          <button type="button" onclick="editRow(this)">Edit</button>
          <button type="button" onclick="saveRow(this, '${id}')" id="save-btn" style="display:none;">Save</button>  
        </td>
        <td>
					<button type="button" onclick="deleteRow(this, '${id}')">Delete</button>
					<button type="button" onclick="cancelEdit(this, '${id}')" id="cancel-btn" style="display:none;">Cancel</button>
				</td>
      `;
      tableBody.appendChild(row);
    }
  });
  localStorage.removeItem("books_ids");
};

// Edit Btn Function
function editRow(btn) {
  var row = btn.closest("tr");
  var inputs = row.querySelectorAll("input");
  for (var i = 0; i < inputs.length; i++) {
    inputs[i].disabled = false;
  }

  var buttons = row.querySelectorAll("button");
  buttons[0].style.display = "none"; // edit-btn
  buttons[1].style.display = "inline-block"; // save-btn
  buttons[2].style.display = "none"; // delete-btn
  buttons[3].style.display = "inline-block"; // cancel-btn

  // row.dataset.oldValues = JSON.stringify(
  //   Array.from(inputs).map(function (input) {
  //     return input.value;
  //   })
  // );
}

// Validation Functions
function isValidTitle(title) {
  return title.trim() !== "";
}

function isValidPrice(price) {
  return !isNaN(price) && Number(price) > 0;
}

function isValidName(name) {
  return name.trim() !== "";
}

function isValidEmail(email) {
  var emailRegex = /^[a-z0-9]+@[a-z0-9]+\.[a-z]+$/i;
  return emailRegex.test(email);
}

// Save Btn Function
function saveRow(btn, id) {
  var row = btn.closest("tr");
  var inputs = row.querySelectorAll("input");

  var title = inputs[0].value.trim();
  var price = inputs[1].value.trim();
  var name = inputs[2].value.trim();
  var email = inputs[3].value.trim();

  if (!isValidTitle(title)) {
    alert("Title is Required.");
    return;
  }

  if (!isValidPrice(price)) {
    alert("Price must be greater than 0.");
    return;
  }

  if (!isValidName(name)) {
    alert("Author name is Required.");
    return;
  }

  if (!isValidEmail(email)) {
    alert("Author Email is not valid.");
    return;
  }

  var updatedBook = {
    title: title,
    price: price,
    author: {
      name: name,
      email: email,
    },
  };

  localStorage.setItem(id, JSON.stringify(updatedBook));

  for (var i = 0; i < inputs.length; i++) {
    inputs[i].disabled = true;
  }

  var buttons = row.querySelectorAll(" button");
  buttons[0].style.display = "inline-block"; // edit-btn
  buttons[1].style.display = "none"; // save-btn
  buttons[2].style.display = "inline-block"; // delete-btn
  buttons[3].style.display = "none"; // cancel-btn
}

// Cancel Btn Function
function cancelEdit(btn, id) {
  var row = btn.closest("tr");
  var inputs = row.querySelectorAll("input");
  var oldBookInfo = JSON.parse(localStorage.getItem(id) || "[]");

  inputs[0].value = oldBookInfo.title;
  inputs[1].value = oldBookInfo.price;
  inputs[2].value = oldBookInfo.author.name;
  inputs[3].value = oldBookInfo.author.email;

  // var oldValues = JSON.parse(row.dataset.oldValues || "[]");

  // for (var i = 0; i < inputs.length; i++) {
  //   inputs[i].value = oldValues[i];
  //   inputs[i].disabled = true;
  // }

  for (var i = 0; i < inputs.length; i++) {
    inputs[i].disabled = true;
  }

  var buttons = row.querySelectorAll("button");
  buttons[0].style.display = "inline-block"; // edit-btn
  buttons[1].style.display = "none"; // save-btn
  buttons[2].style.display = "inline-block"; // delete-btn
  buttons[3].style.display = "none"; // cancel-btn
}

// Delete Btn Function
function deleteRow(btn, id) {
  var row = btn.closest("tr");
  row.remove();

  localStorage.removeItem(id);

  // var ids = JSON.parse(localStorage.getItem("books_ids") || "[]");
  // ids = ids.filter(function (item) {
  //   return item !== id;
  // });
  // localStorage.setItem("books_ids", JSON.stringify(ids));
}
