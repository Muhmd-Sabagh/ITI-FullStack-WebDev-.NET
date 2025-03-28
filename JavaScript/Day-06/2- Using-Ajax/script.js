/*
	Get users information from an API and display it
*/

// Get all users button click event
function getAllUsers(e) {
  allUsersTBody.innerHTML = "";
  var xhr = new XMLHttpRequest();
  xhr.open("GET", "https://jsonplaceholder.typicode.com/users");
  xhr.send("");

  xhr.onreadystatechange = function () {
    if (xhr.readyState == 4 && xhr.status == 200) {
      var users = JSON.parse(xhr.response);
      console.log(users);
      displayAllUsers(users);
    }
  };

  // e.target.disabled = true;
}

// Display all users in the table
var allUsersTBody = document.getElementsByTagName("tbody")[0];
function displayAllUsers(users) {
  for (var i = 0; i < users.length; i++) {
    var userRow = document.createElement("tr");
    userRow.innerHTML = `
		<td>${users[i].id}</td>
		<td>${users[i].name}</td>
		<td>${users[i].email}</td>
		<td>
		<button id="${
      i + 1
    }" class="details-btn" onclick="getUserDetails(event)">View User</button>
		<button class="delete-btn" onclick="deleteUser(event)">Delete User</button>
		</td>
		`;

    allUsersTBody.appendChild(userRow);
  }
}

// Get user details button click event
var userDetailsTBody = document.getElementsByTagName("tbody")[1];
function getUserDetails(e) {
  var xhr = new XMLHttpRequest();
  xhr.open("GET", "https://jsonplaceholder.typicode.com/users/" + e.target.id);
  xhr.send("");

  xhr.onreadystatechange = function () {
    if (xhr.readyState == 4 && xhr.status == 200) {
      var user = JSON.parse(xhr.response);
      userDetailsTBody.innerHTML = "";
      displayUserDetails(user);
    }
  };
}

// Display user details in a new table
function displayUserDetails(user, parentKey = "") {
  for (var key in user) {
    var value = user[key];
    var fullKey = parentKey ? `${parentKey}.${key}` : key;
    if (typeof value === "object" && value !== null) {
      var row = document.createElement("tr");
      row.innerHTML = `<td colspan="2">${fullKey}</td>`;
      userDetailsTBody.appendChild(row);
      displayUserDetails(value, fullKey);
    } else {
      var row = document.createElement("tr");
      row.innerHTML = `<td>${fullKey}</td><td>${value}</td>`;
      userDetailsTBody.appendChild(row);
    }
  }
}

// Delete user button click event
function deleteUser(e) {
  e.target.parentElement.parentElement.remove();
}
