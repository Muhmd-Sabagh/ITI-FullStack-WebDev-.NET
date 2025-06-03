$(function () {
  $.ajax({
    url: "https://localhost:7055/api/student",
    method: "GET",
    success: function (data) {
      let html = `
          <table border="1" cellpadding="8" cellspacing="0">
            <thead>
              <tr>
                <th>ID</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Address</th>
                <th>Age</th>
                <th>Department</th>
                <th>Supervisor</th>
              </tr>
            </thead>
            <tbody>
        `;

      data.forEach(function (student) {
        html += `
            <tr>
              <td>${student.id}</td>
              <td>${student.fname}</td>
              <td>${student.lname}</td>
              <td>${student.address}</td>
              <td>${student.age}</td>
              <td>${student.dept_Name ?? "N/A"}</td>
              <td>${student.super_Name ?? "N/A"}</td>
            </tr>
          `;
      });

      html += `
            </tbody>
          </table>
        `;

      $("#students-container").html(html);
    },
    error: function () {
      $("#students-container").html(
        "<p style='color:red;'>Failed to load data.</p>"
      );
    },
  });
});
