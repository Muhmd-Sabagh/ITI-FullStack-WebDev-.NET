// Function to toggle between light and dark mode
function toggleTheme() {
  var body = document.body;
  var themeToggleBtn = document.getElementById("theme-toggle");

  body.classList.toggle("dark-mode");

  if (body.classList.contains("dark-mode")) {
    themeToggleBtn.innerHTML = "☀️ Light Mode";
  } else {
    themeToggleBtn.innerHTML = "🌙 Dark Mode";
  }
}
