// Main
var inputName = document.getElementById("name");
var inputAge = document.getElementById("age");
var errorMessages = document.getElementsByTagName("span");
var tableBody = document.getElementsByTagName("tbody")[0];
var errorDetected = true;
var id = 1;

// Show Errors for name criteria
function nameErrorMessage() {
  if (inputName.value == "") {
    errorMessages[0].style.visibility = "visible";
    errorDetected = true;
  } else if (inputName.value.length < 3) {
    errorMessages[1].style.visibility = "visible";
    errorMessages[0].style.visibility = "hidden";
    errorDetected = true;
  } else {
    errorMessages[0].style.visibility = "hidden";
    errorMessages[1].style.visibility = "hidden";
    errorDetected = false;
  }
}

// Show Errors for age criteria
function ageErrorMessage() {
  if (inputAge.value == "") {
    errorMessages[2].style.visibility = "visible";
    errorDetected = true;
  } else if (inputAge.value < 18) {
    errorMessages[3].style.visibility = "visible";
    errorMessages[2].style.visibility = "hidden";
    errorDetected = true;
  } else {
    errorMessages[2].style.visibility = "hidden";
    errorMessages[3].style.visibility = "hidden";
    errorDetected = false;
  }
}

// Add student info in the table when button clicked
function addStudent() {
  if (!errorDetected) {
    // Duplicates check
    if (isDuplicate(inputName.value, inputAge.value)) {
      alert("This student already exists!");
      return;
    }

    var tableRow = document.createElement("tr");
    tableRow.innerHTML = `
			<td>${id}</td>
			<td>${inputName.value}</td>
			<td>${inputAge.value}</td>
			<td><button class="delete-btn" onclick="deleteStudent(event)">Delete Student</button></td>
		`;
    tableBody.append(tableRow);
    id++;

    inputName.value = "";
    inputAge.value = "";
  }
}

// Detect duplicates
function isDuplicate(name, age) {
  var rows = tableBody.querySelectorAll("tr");
  var rowName;
  var rowAge;
  for (const row of rows) {
    rowName = row.cells[1].textContent;
    rowAge = row.cells[2].textContent;
    if (rowName === name && rowAge === age) {
      return true;
    }
  }
  return false;
}

// Delete the selected student info from the table
function deleteStudent(e) {
  if (confirm("Are you sure you want to delete this student?")) {
    var deleteButton = e.target;
    var td = deleteButton.parentElement;
    var tr = td.parentElement;
    tr.remove();
  }
}
