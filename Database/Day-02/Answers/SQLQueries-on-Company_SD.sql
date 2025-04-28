-- DAY-02 LAB QUERIES

USE Company_SD;
GO

-- Display all the employees Data.
SELECT *
FROM Employee;
GO

-- Display the employee First name, last name, Salary and Department number.
SELECT (Fname+' '+Lname) as FullName, Salary, Dno
FROM Employee;
GO

-- Display all the projects names, locations and the department which is responsible about it.
SELECT Pname, Plocation, Dnum
FROM Project;
GO

-- If you know that the company policy is to pay an annual commission for each employee
--  with specific percent equals 10% of his/her annual salary .Display each employee full name
--  and his annual commission in an ANNUAL COMM column (alias).
SELECT (Fname+' '+Lname) as FullName, (Salary * 12 * 0.1) as [ANNUAL COMM]
FROM Employee;
GO

-- Display the employees Id, name who earns more than 1000 LE monthly.
SELECT SSN, (Fname+' '+Lname) as FullName
FROM Employee
WHERE Salary > 1000;
GO

-- Display the employees Id, name who earns more than 10000 LE annually.
SELECT SSN, (Fname+' '+Lname) as FullName
FROM Employee
WHERE (Salary * 12) > 10000;
GO

-- Display the names and salaries of the female employees 
SELECT (Fname+' '+Lname) as FullName, Salary
FROM Employee
WHERE Sex = 'F';
GO

-- Display each department id, name which managed by a manager with id equals 968574.
SELECT Dnum, Dname
FROM Departments
WHERE MGRSSN = 968574;
GO

-- Dispaly the ids, names and locations of  the pojects which controled with department 10.
SELECT Pnumber, Pname, Plocation
FROM Project
WHERE Dnum = 10;
GO