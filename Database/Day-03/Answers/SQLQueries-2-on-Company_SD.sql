-- DAY-03 LAB QUERIES
-- PART-01 USING OF JOIN

USE Company_SD;
GO

-- Helper Queries
SELECT * FROM Employee;
SELECT * FROM Dependent;
SELECT * FROM Departments;
SELECT * FROM Project;
GO

-- 1. Display the Department id, name and id and the name of its manager.
SELECT Dnum, Dname, SSN, (Fname+' '+Lname) AS Full_Name
FROM Departments D
INNER JOIN Employee E
ON D.MGRSSN = E.SSN;
GO

-- 2. Display the name of the departments and the name of the projects under its control.
SELECT Dname, Pname
FROM Departments D
INNER JOIN Project P
ON D.Dnum = P.Dnum;
GO

-- 3. Display the full data about all the dependence associated with the name of the employee they depend on him/her.
SELECT D.*, (E.Fname+' '+E.Lname) AS Emp_Full_Name
FROM Dependent D
INNER JOIN Employee E
ON D.ESSN = E.SSN;
GO

-- 4. Display the Id, name and location of the projects in Cairo or Alex city.
SELECT Pnumber, Pname, Plocation
FROM Project
WHERE City in ('cairo', 'alex');
GO

-- 5. Display the Projects full data of the projects with a name starts with "a" letter.
SELECT *
FROM Project
WHERE Pname LIKE 'a%';
GO

-- 6. display all the employees in department 30 whose salary from 1000 to 2000 LE monthly.
SELECT *
FROM Employee
WHERE Dno = 30 AND Salary BETWEEN 1000 AND 2000;
GO

-- 7. Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
SELECT (E.Fname+' '+E.Lname) AS Emp_Full_Name, E.Dno, W.Hours, P.Pname
FROM Employee E
JOIN Works_for W ON E.SSN = W.ESSn
JOIN Project P ON W.Pno = P.Pnumber
wHERE E.Dno = 10 AND W.Hours >= 10 AND P.Pname = 'AL Rabwah';
GO

-- 8. Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT (E1.Fname+' '+E1.Lname) AS Full_Name
FROM Employee E1
LEFT JOIN Employee E2 ON E1.Superssn = E2.SSN
WHERE E2.Fname = 'Kamel' AND E2.Lname = 'Mohamed';
GO

-- 9. Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
SELECT (E.Fname+' '+E.Lname) AS Emp_Full_Name, P.Pname
FROM Employee E
JOIN Works_for W ON E.SSN = W.ESSn
JOIN Project P ON W.Pno = P.Pnumber
ORDER BY P.Pname;
GO

-- 10. For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.
SELECT P.Pnumber, D.Dname, E.Lname AS ManagerLastName, E.Address, E.Bdate
FROM Project P
JOIN Departments D ON P.Dnum = D.Dnum
JOIN Employee E ON D.MGRSSN = E.SSN
WHERE P.City = 'Cairo';
GO

-- 11. Display All Data of the managers
SELECT DISTINCT E.*
FROM Employee E
JOIN Departments D ON E.Ssn = D.MGRSSN;
GO

-- 12. Display All Employees data and the data of their dependents even if they have no dependents
SELECT E.*, D.Bdate, D.Dependent_name, D.Sex
FROM Employee E
LEFT JOIN Dependent D ON E.SSN = D.ESSN;
GO

-- 13. Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO Employee 
    (Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno)
VALUES
    ('Muhammad', 'Abdullah', 102672, '1998-09-11', 'Menoufia', 'M', 3000, 112233, 30);
GO

-- 14. Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
INSERT INTO Employee 
    (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
VALUES
    ('Ali', 'Ahmed', 102660, '2000-03-05', 'Menoufia', 'M', 30);
GO

-- 15. Upgrade your salary by 20 % of its last value.
UPDATE Employee
SET Salary = Salary * 1.2
WHERE SSN = 102672;
GO