/*
	Display users posts
*/

// Fetching users details
async function getUsers() {
  try {
    let response = await fetch("https://jsonplaceholder.typicode.com/users");
    let users = await response.json();
    displayUsersNames(users);
  } catch (error) {
    console.log(error);
  }
}

function displayUsersNames(users) {
  let usersBtns = document.getElementById("users-btns");
  for (let i = 0; i < users.length; i++) {
    let userBtn = document.createElement("button");
    userBtn.textContent = users[i].name;
    userBtn.type = "button";
    userBtn.id = users[i].id;
    userBtn.classList.add("btn", "btn-danger");
    userBtn.onclick = function () {
      fetchUserPosts(users[i].id);
    };
    usersBtns.appendChild(userBtn);
  }
}

async function fetchUserPosts(userId) {
  try {
    let response = await fetch(
      `https://jsonplaceholder.typicode.com/posts?userId=${userId}`
    );
    let userPosts = await response.json();
    displayUserPosts(userPosts);
  } catch (error) {
    console.log(error);
  }
}

function displayUserPosts(posts) {
  let userPosts = document.getElementById("user-posts");
  userPosts.innerHTML = "";
  for (let i = 0; i < posts.length; i++) {
    let postCard = document.createElement("div");
    postCard.classList.add("card", "text-bg-white", "mb-3", "w-75");
    postCard.innerHTML = `<h2 class='card-header'>Post_${
      i + 1
    }</h2><div class='card-body'><h3 class='card-title'>${
      posts[i].title
    }</h3><p class='card-text'>${posts[i].body}</p>`;
    userPosts.appendChild(postCard);
  }
}
