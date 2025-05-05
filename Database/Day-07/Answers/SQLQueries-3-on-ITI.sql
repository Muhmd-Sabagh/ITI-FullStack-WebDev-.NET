-- DAY-07 LAB

-- Helper Queries
USE ITI;
SELECT * FROM Course;
SELECT * FROM Department;
SELECT * FROM Ins_Course;
SELECT * FROM Instructor;
SELECT * FROM Stud_Course;
SELECT * FROM Student;
SELECT * FROM Topic;
GO

-- 1. Create a view that displays student full name, course name if the student has a grade more than 50.
CREATE VIEW VW_StGradesAbove50 AS
SELECT
	ISNULL(S.St_Fname+' ', '') + ISNULL(S.St_Lname, '') AS St_FullName,
	C.Crs_Name
FROM Student S
JOIN Stud_Course SC ON S.St_Id = SC.St_Id
JOIN Course C ON SC.Crs_Id = C.Crs_Id
WHERE SC.Grade > 50;
GO

SELECT * FROM VW_StGradesAbove50;
GO

-- 2. Create an Encrypted view that displays manager names and the topics they teach.
UPDATE Department SET Dept_Manager = 2 WHERE Dept_Id = 10;
UPDATE Department SET Dept_Manager = 12 WHERE Dept_Id = 20;
UPDATE Department SET Dept_Manager = 1 WHERE Dept_Id = 30;
UPDATE Department SET Dept_Manager = 10 WHERE Dept_Id = 40;
UPDATE Department SET Dept_Manager = 5 WHERE Dept_Id = 50;
UPDATE Department SET Dept_Manager = 4 WHERE Dept_Id = 60;
UPDATE Department SET Dept_Manager = 14 WHERE Dept_Id = 70;
GO

CREATE VIEW VW_MGRTopics
WITH ENCRYPTION
AS
SELECT I.Ins_Name AS Manager_Name, T.Top_Name
FROM Instructor I
JOIN Department D ON I.Ins_Id = D.Dept_Manager
JOIN Ins_Course IC ON I.Ins_Id = IC.Ins_Id
JOIN Course C ON IC.Crs_Id = C.Crs_Id
JOIN Topic T ON C.Top_Id = T.Top_Id;
GO

SELECT * FROM VW_MGRTopics;
GO

sp_helptext 'VW_MGRTopics'; -- Encrypted
GO

-- 3. Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department.
CREATE VIEW VW_SD_Java_Instructors AS
SELECT I.Ins_Name, D.Dept_Name
FROM Instructor I
JOIN Department D ON I.Dept_Id = D.Dept_Id
WHERE D.Dept_Name IN ('SD', 'Java');
GO

-- 4. Create a view “V1” that displays student data for student who lives in Alex or Cairo. 
--	Note: Prevent the users to run the following query 
--	UPDATE V1 SET st_address=’tanta’ WHERE st_address=’alex’;
CREATE VIEW V1 AS
SELECT *
FROM Student
WHERE St_Address IN ('Alex', 'Cairo')
WITH CHECK OPTION;
GO

SELECT * FROM V1;
UPDATE V1 SET St_Address='Tanta';
GO

-- 5. Create a view that will display the project name and the number of employees work on it. “Use Company DB”
USE Company_SD;
SELECT * FROM Project;
SELECT * FROM Works_for;
SELECT * FROM Employee;
GO

CREATE VIEW VW_ProjectEmployeesCount AS
SELECT P.Pname, COUNT(WF.ESSn) AS EmpCount
FROM Project P
JOIN Works_for WF ON P.Pnumber = WF.Pno
GROUP BY P.Pname
GO

-- 6. Create the following schema and transfer the following tables to it
--	a. Company Schema 
--		i. Department table (Programmatically)
--		ii. Project table (by wizard)
--	b. Human Resource Schema
--		i. Employee table (Programmatically)
CREATE SCHEMA Company;
GO
CREATE SCHEMA HumanResources;
GO

ALTER SCHEMA Company TRANSFER dbo.Departments;
-- Project table will be transfered using Wizard
ALTER SCHEMA HumanResources TRANSFER dbo.Employee;
GO

-- 7. Create index on column (manager_Hiredate) that allow u to cluster the data in table Department. What will happen?  -> Use ITI DB
USE ITI;
GO

CREATE CLUSTERED INDEX IX_MGRHireDate
ON Department(Manager_hiredate)		-- Cannot create more than one clusterd index on the table
GO

-- 8. Create index that allow u to enter unique ages in student table. What will happen?  -> Use ITI DB
CREATE UNIQUE INDEX IX_UniqueAge
ON Student(St_Age)		-- Connot create the unique index because there are dublicated values
GO

-- 9. Create a cursor for Employee table that increases Employee salary by 10% if Salary <3000 and increases it by 20% if Salary >=3000. -> Use company DB
USE Company_SD;
SELECT * FROM HumanResources.Employee;
GO

DECLARE @Id INT, @Salary FLOAT;

DECLARE salary_cursor CURSOR FOR
SELECT SSN, Salary FROM HumanResources.Employee WHERE Salary IS NOT NULL;

OPEN salary_cursor;
FETCH NEXT FROM salary_cursor INTO @Id, @Salary;

WHILE @@FETCH_STATUS = 0
BEGIN
    IF @Salary < 3000
        UPDATE HumanResources.Employee SET Salary = Salary * 1.1 WHERE SSN = @Id;
    ELSE
        UPDATE HumanResources.Employee SET Salary = Salary * 1.2 WHERE SSN = @Id;

    FETCH NEXT FROM salary_cursor INTO @Id, @Salary;
END

CLOSE salary_cursor;
DEALLOCATE salary_cursor;
GO

-- 10. Display Department name with its manager name using cursor. -> Use ITI DB
USE ITI;
GO

DECLARE @Results TABLE (DeptName NVARCHAR(100), ManagerName NVARCHAR(100));

DECLARE @Dept VARCHAR(100), @Mgr VARCHAR(100);

DECLARE dept_cursor CURSOR FOR
SELECT D.Dept_Name, I.Ins_Name
FROM Department D
JOIN Instructor I ON D.Dept_Manager = I.Ins_Id;

OPEN dept_cursor;
FETCH NEXT FROM dept_cursor INTO @Dept, @Mgr;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO @Results VALUES (@Dept, @Mgr);
    FETCH NEXT FROM dept_cursor INTO @Dept, @Mgr;
END

CLOSE dept_cursor;
DEALLOCATE dept_cursor;

SELECT * FROM @Results;
GO

-- 11. Try to display all instructor names in one cell separated by comma. Using Cursor . -> Use ITI DB
DECLARE @Name VARCHAR(MAX) = '', @Temp VARCHAR(100);

DECLARE ins_cursor CURSOR FOR
SELECT Ins_Name FROM Instructor;

OPEN ins_cursor;
FETCH NEXT FROM ins_cursor INTO @Temp;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @Name = @Name + @Temp + ', ';
    FETCH NEXT FROM ins_cursor INTO @Temp;
END

CLOSE ins_cursor;
DEALLOCATE ins_cursor;

SELECT SUBSTRING(@Name, 1, LEN(@Name) - 1) AS AllInstructors;

-- 12.	Try to generate script from DB ITI that describes all tables and views in this DB
-- Script generation faild -> because there is an encrypted view (VE_MGRTopics)