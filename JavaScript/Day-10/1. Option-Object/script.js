/*
	A function that accepts multiple parameters
	to generate course information and display it.
	assume course information must contains courseName, courseDuation, courseOwner.
*/

function addCourse(course) {
  return Object.assign(
    { courseName: "null", courseDuration: 0, courseOwner: "null" },
    course
  );
}

let newCourse = addCourse({
  courseName: "JavaScript",
  courseDuration: 3,
  courseOwner: "Eng\\Sara",
});

console.log(newCourse);
