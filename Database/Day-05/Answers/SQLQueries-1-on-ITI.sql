-- DAY-05 LAB
-- PART-01 QUERIES ON ITI DB

-- Helper Queries
USE ITI
SELECT * FROM Course
SELECT * FROM Department
SELECT * FROM Ins_Course
SELECT * FROM Instructor
SELECT * FROM Stud_Course
SELECT * FROM Student
SELECT * FROM Topic

-- 1. Retrieve number of students who have a value in their age. 
SELECT COUNT(*) AS CountOfStudentsWithAge
FROM Student
WHERE St_Age IS NOT NULL;
GO

-- 2. Get all instructors Names without repetition
SELECT DISTINCT Ins_Name
FROM Instructor;
GO

-- 3. Display student with the following Format (use isNull function)
-- | Student ID | Student Full Name | Department name |
SELECT
	S.St_Id AS [Student ID],
	ISNULL(S.St_Fname + ' ', '') + ISNULL(S.St_Lname, '') AS [Student Full Name],
	ISNULL(D.Dept_Name, 'No Dept') AS [Department name]
FROM Student S
LEFT JOIN Department D ON S.Dept_Id = D.Dept_Id;
GO

-- 4. Display instructor Name and Department Name 
-- Note: display all the instructors if they are attached to a department or not
SELECT I.Ins_Name, D.Dept_Name
FROM Instructor I
LEFT JOIN Department D ON I.Dept_Id = D.Dept_Id;
GO

-- 5. Display student full name and the name of the course he is taking For only courses which have a grade.
SELECT
	ISNULL(S.St_Fname + ' ', '') + ISNULL(S.St_Lname, '') AS [Student Full Name],
	C.Crs_Name
FROM Student S
JOIN Stud_Course SC ON S.St_Id = SC.St_Id
JOIN Course C ON SC.Crs_Id = C.Crs_Id
WHERE Grade IS NOT NULL;
GO

-- 6. Display number of courses for each topic name
SELECT COUNT(C.Crs_Id) AS NumOFCourses, T.Top_Name
FROM Course C
JOIN Topic T ON C.Top_Id = T.Top_Id
GROUP BY T.Top_Name;
GO

-- 7. Display max and min salary for instructors
SELECT MAX(Salary) AS MAX_INS_Salary, MIN(Salary) AS MIN_INS_Salary
FROM Instructor;
GO

-- 8. Display instructors who have salaries less than the average salary of all instructors.
SELECT Ins_Id, Ins_Name
FROM Instructor
WHERE Salary < (SELECT AVG(Salary) FROM Instructor);
GO

-- 9. Display the Department name that contains the instructor who receives the minimum salary.
SELECT D.Dept_Name
FROM Instructor I
JOIN Department D ON I.Dept_Id = D.Dept_Id
WHERE I.Salary = (SELECT MIN(Salary) FROM Instructor)
GO

-- 10. Select max two salaries in instructor table. 
SELECT TOP(2)*
FROM Instructor
ORDER BY Salary DESC
GO

-- 11. Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
SELECT Ins_Name, COALESCE(CAST(Salary AS VARCHAR(20)), 'bouns') AS Salary
FROM Instructor
GO

-- 12. Select Average Salary for instructors 
SELECT AVG(Salary)
FROM Instructor
GO

-- 13. Select Student first name and the data of his supervisor.
SELECT S1.St_Fname AS [Student Name], S2.*
FROM Student S1
JOIN Student S2 ON S1.St_Id = S2.St_super;
GO

-- 14. Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
SELECT Salary, Dept_Id
FROM (SELECT	
		*,
		ROW_NUMBER() OVER(PARTITION BY Dept_Id ORDER BY Salary DESC) AS RN
	 FROM Instructor
	 WHERE Salary IS NOT NULL
	 ) AS SortedTable
WHERE RN <= 2;
GO

-- 15. Write a query to select a random student from each department.  “using one of Ranking Functions”
SELECT St_Id, St_Fname, St_Lname, St_Address, St_Age, Dept_Id, St_super
FROM (SELECT 
		*, 
		ROW_NUMBER() OVER(PARTITION BY Dept_Id ORDER BY NEWID()) AS RN
	 FROM Student
	 WHERE Dept_Id IS NOT NULL
	 ) AS RankedStudents
WHERE RN = 1;
GO