-- DAY-06 LAB

-- Helper Queries
USE ITI
SELECT * FROM Course
SELECT * FROM Department
SELECT * FROM Ins_Course
SELECT * FROM Instructor
SELECT * FROM Stud_Course
SELECT * FROM Student
SELECT * FROM Topic
GO

-- 1. Create a scalar function that takes date and returns Month name of that date.
CREATE FUNCTION GetMonthName(@Date DATE)
RETURNS VARCHAR(20)
AS
BEGIN
	RETURN MONTH(@Date)
END
GO

SELECT dbo.GetMonthName('2025-08-04') AS MonthName;
GO

-- 2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
CREATE FUNCTION ValuesBetweenTwoInt(@Num1 INT, @Num2 INT)
RETURNS @Values TABLE (Value INT)
AS
BEGIN
	DECLARE @i INT = @Num1 + 1
	WHILE @i < @Num2
	BEGIN
		INSERT INTO @Values VALUES (@i)
		SET @i += 1
	END
	RETURN
END
GO

SELECT * FROM ValuesBetweenTwoInt(5, 10)
GO

-- 3. Create inline function that takes Student No and returns Department Name with Student full name.
CREATE FUNCTION GetStudentInfo (@St_Id INT)
RETURNS TABLE
AS
RETURN (
	SELECT
		ISNULL(S.St_Fname+' ','') + ISNULL(S.St_Lname,'') AS St_FullName,
		D.Dept_Name
	FROM Student S
	JOIN Department D ON S.Dept_Id = D.Dept_Id
	WHERE S.St_Id = @St_Id
)
GO

SELECT * FROM GetStudentInfo(5)
GO

-- 4. Create a scalar function that takes Student ID and returns a message to user 
--	a. If first name and Last name are null then display 'First name & last name are null'
--	b. If First name is null then display 'first name is null'
--	c. If Last name is null then display 'last name is null'
--	d. Else display 'First name & last name are not null'
CREATE FUNCTION CheckStudentName (@St_Id INT)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Fname VARCHAR(50), @Lname VARCHAR(50), @Message VARCHAR(50)
    SELECT @Fname = St_Fname, @Lname = St_Lname FROM Student WHERE St_Id = @St_Id

    IF @Fname IS NULL AND @Lname IS NULL
        SET @Message = 'First name & last name are null'
    ELSE IF @Fname IS NULL
        SET @Message = 'first name is null'
    ELSE IF @Lname IS NULL
        SET @Message = 'last name is null'
    ELSE
        SET @Message = 'First name & last name are not null'

	RETURN @Message
END
GO

SELECT dbo.CheckStudentName(1)
GO

-- 5. Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date.
CREATE FUNCTION GetManagerInfo (@Mgr_Id INT)
RETURNS TABLE
AS
RETURN
(
    SELECT D.Dept_Name, I.Ins_Name, D.Manager_hiredate
    FROM Department D
    JOIN Instructor I ON D.Dept_Manager = I.Ins_Id
    WHERE D.Dept_Manager = @Mgr_Id
)
GO

SELECT * FROM GetManagerInfo(2)
GO

-- 6. Create multi-statements table-valued function that takes a string
--	If string='first name' returns student first name
--	If string='last name' returns student last name
--	If string='full name' returns Full Name from student table
-- Note: Use “ISNULL” function
CREATE FUNCTION GetStudentNamePart (@Part VARCHAR(20))
RETURNS @Result TABLE (Value VARCHAR(100))
AS
BEGIN
    IF @Part = 'first name'
        INSERT INTO @Result
		SELECT ISNULL(St_Fname, '')
		FROM Student
    ELSE IF @Part = 'last name'
        INSERT INTO @Result
		SELECT ISNULL(St_Lname, '')
		FROM Student
    ELSE IF @Part = 'full name'
        INSERT INTO @Result
		SELECT ISNULL(St_Fname + ' ', '') + ISNULL(St_Lname, '')
		FROM Student
    RETURN
END
GO

SELECT * FROM GetStudentNamePart('full name')
GO

-- 7. Write a query that returns the Student No and Student first name without the last char.
SELECT St_Id, SUBSTRING(St_Fname,1 , LEN(St_Fname) - 1) AS FName_Without_LChar
FROM Student
WHERE St_Fname IS NOT NULL;
GO

-- 8. Wirte query to delete all grades for the students Located in SD Department.
DELETE SC FROM Stud_Course SC
JOIN Student S ON SC.St_Id = S.St_Id
JOIN Department D ON S.Dept_Id = D.Dept_Id
WHERE D.Dept_Name = 'SD'

-- 9. Using Merge statement between the following two tables [User ID, Transaction Amount].
USE CompanyDB
GO

CREATE TABLE DailyTransactions (
	UserID INT PRIMARY KEY,
	TransactionAmount INT
);

CREATE TABLE LastTransactions (
	UserID INT PRIMARY KEY,
	TransactionAmount INT
);
GO

INSERT INTO DailyTransactions VALUES	(1, 1000),
										(2, 2000),
										(3, 1000);

INSERT INTO LastTransactions VALUES		(1, 4000),
										(4, 2000),
										(2, 10000);
GO

SELECT * FROM DailyTransactions
SELECT * FROM LastTransactions
GO

MERGE DailyTransactions AS target
USING LastTransactions AS source
ON target.UserID = source.UserID

WHEN MATCHED THEN 
    UPDATE SET target.TransactionAmount = source.TransactionAmount

WHEN NOT MATCHED BY TARGET THEN
    INSERT (UserID, TransactionAmount)
    VALUES (source.UserID, source.TransactionAmount);
GO

-- 10. Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to select and insert data into tables and deny Delete and update.