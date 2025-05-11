-- DAY-08 LAB
-- PART-01 QUERIES ON ITI and Company_SD DBs

-- Helper Queries
SELECT * FROM Course
SELECT * FROM Department
SELECT * FROM Ins_Course
SELECT * FROM Instructor
SELECT * FROM Stud_Course
SELECT * FROM Student
SELECT * FROM Topic
GO

SELECT * FROM HumanResources.Employee
SELECT * FROM Dependent
SELECT * FROM Company.Departments
SELECT * FROM Company.Project
SELECT * FROM Works_for
GO

-- 1. Create a stored procedure without parameters to show the number of students per department name.[use ITI DB]
USE ITI
GO

CREATE PROC numOfStudentsInDepts
AS
	SELECT Dept_Name, COUNT(S.St_Id) AS [# at this dept]
	FROM Department D
	INNER JOIN Student S ON D.Dept_Id = S.Dept_Id
	GROUP BY d.Dept_Name;
GO

numOfStudentsInDepts
GO

-- 2. Create a stored procedure that will check for the # of employees in the project p1 if they are more
--	  than 3 print message to the user “'The number of employees in the project p1 is 3 or more'”
--	  if they are less display a message to the user “'The following employees work for the project p1'”
--	  in addition to the first name and last name of each one. [Company DB]
USE Company_SD;
GO

CREATE PROC checkingEmployeeInProjects
AS
	DECLARE @totalNumAtProject INT;
	DECLARE @t AS TABLE(Fname VARCHAR(50) , Lname VARCHAR(50))

	SELECT @totalNumAtProject = COUNT(E.SSN)
	FROM HumanResources.Employee AS E
	INNER JOIN Company.Departments D ON E.Dno = D.Dnum
	INNER JOIN Company.Project P ON D.Dnum = P.Dnum
	WHERE P.Pname = 'p1';
	IF @totalNumAtProject >= 3
		SELECT 'The number of employees in the project p1 is 3 or more'
	ELSE
	BEGIN
		INSERT INTO @t
		SELECT E.Fname , E.Lname
		FROM HumanResources.Employee AS E
		INNER JOIN Company.Departments D ON E.Dno = D.Dnum
		INNER JOIN Company.Project P ON D.Dnum = p.Dnum
		WHERE P.Pname = 'p1';
	END
	SELECT 'These are who are working on p1'
	SELECT * FROM @t
GO

checkingEmployeeInProjects
GO

-- 3. Create a stored procedure that will be used in case there is an old employee has left the project
--	  and a new one become instead of him. The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number)
--	  and it will be used to update works_on table. [Company DB]
USE Company_SD;
GO

CREATE PROC replaceEmpWithAnother
@oldId INT, @newId INT ,@projNum INT
AS
	UPDATE Works_for
	SET ESSn = @newId
	WHERE ESSn = @oldId AND Pno = @projNum
GO

replaceEmpWithAnother 968574,102672,400
GO

-- 4. add column budget in project table and insert any draft values in it
--	  then Create an Audit table with the following structure 
--	  ProjectNo 	UserName 	ModifiedDate 	Budget_Old 	Budget_New 
--	  p2 			Dbo 		2008-01-31		95000 		200000 

--	  This table will be used to audit the update trials on the Budget column (Project table, Company DB)
--	  Example:
--		If a user updated the budget column then the project number, user name that made that update,
--		the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--	  Note: This process will take place only if the user updated the budget column
USE Company_SD;
GO

ALTER TABLE Company.Project ADD Budget INT
GO

CREATE TABLE History_Audit(
	projectNo INT,
	username VARCHAR(50),
	modifiedDate DATE,
	oldBudget INT,
	newBudget INT
	)
GO

CREATE TRIGGER auditTrigger
ON Company.Project
AFTER UPDATE
AS
	DECLARE @new_budget INT , @old_budget INT , @projNum INT
	IF(UPDATE(Budget))
	BEGIN
		SELECT	@new_budget = Budget , @projNum = Pnumber FROM inserted
		SELECT	@old_budget = Budget , @projNum = Pnumber FROM deleted
		INSERT INTO History_Audit
		VALUES(@projNum , SUSER_NAME(), GETDATE(),@old_budget, @new_budget);
	END
	ELSE
		SELECT 'Update not on budget so it will not be saved in history'
GO

UPDATE Company.Project SET Budget = 50000 WHERE Pnumber = 200
GO

SELECT * FROM History_Audit
GO

-- 5. Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--	  “Print a message for user to tell him that he can’t insert a new record in that table”
USE ITI
GO

CREATE TRIGGER preventInsertion
ON Department
INSTEAD OF INSERT
AS
	SELECT 'Can not insert a new record in this table'
GO

INSERT INTO Department
VALUES(80, 'Prep', 'Preperation', 'Banha', 5, GETDATE());
GO

-- 6. Create a trigger that prevents the insertion Process for Employee table in March [Company DB].
USE Company_SD
GO

CREATE TRIGGER preventMarchInsertion
ON HumanResources.Employee
INSTEAD OF INSERT
AS
BEGIN
	IF Month(GETDATE()) = 3
	BEGIN
		SELECT 'Can not insert a new record in this table in March'
		ROLLBACK TRANSACTION;
        RETURN;
	END

	INSERT INTO HumanResources.Employee
	SELECT *
	FROM inserted;
END
GO

-- 7. Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note)
--	  where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
--	  Server User Name		Date	Note 
USE ITI
GO

CREATE TABLE Student_Audit(
	serverName VARCHAR(50),
	dateOfInsertion DATE,
	note VARCHAR(100)
)
GO

CREATE TRIGGER registerInsertionNote
ON Student
AFTER INSERT
AS
BEGIN
    INSERT INTO Student_Audit (serverName, dateOfInsertion, note)
    SELECT 
        SUSER_NAME(),
        GETDATE(),
        CONCAT(SYSTEM_USER, ' Inserted New Row With Key=', CAST(St_Id AS VARCHAR), ' In Table Student')
    FROM inserted;
END
GO

INSERT INTO Student VALUES (16, 'Omar', 'Adel', 'Giza', 25, 40, 5)
GO

SELECT * FROM Student_Audit
GO

-- 8. Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note)
--	  where note will be“ try to delete Row with Key=[Key Value]”
CREATE TRIGGER registerTryingDeleteNote
ON Student
INSTEAD OF DELETE
AS
	INSERT INTO Student_Audit (serverName, dateOfInsertion, note)
    SELECT 
        SUSER_NAME(),
        GETDATE(),
        CONCAT('Try To Delete Row With Key=', CAST(St_Id AS VARCHAR))
    FROM deleted;
GO

DELETE FROM Student
WHERE St_Id = 16;
GO

SELECT * FROM Student_Audit
GO