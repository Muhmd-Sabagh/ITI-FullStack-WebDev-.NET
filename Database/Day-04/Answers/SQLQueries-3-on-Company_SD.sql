-- DAY-04 LAB QUERIES

-- Helper Queries
USE Company_SD;
SELECT * FROM Employee
SELECT * FROM Dependent
SELECT * FROM Departments
SELECT * FROM Project
SELECT * FROM Works_for
GO

-- 1. Display (Using Union Function)
--		a. The name and the gender of the dependence that's gender is Female and depending on Female Employee.
--		b. And the male dependence that depends on Male Employee.
SELECT D.Dependent_name, D.Sex AS Dependant_gender
FROM Employee E
JOIN Dependent D ON E.SSN = D.ESSN
WHERE E.Sex = 'F' AND D.Sex = 'F'
UNION
SELECT D.Dependent_name, D.Sex AS Dependant_gender
FROM Employee E
JOIN Dependent D ON E.SSN = D.ESSN
WHERE E.Sex = 'M' AND D.Sex = 'M';
GO

-- 2. For each project, list the project name and the total hours per week (for all employees) spent on that project.
SELECT P.Pname, SUM(W.Hours)
FROM Project P
JOIN Works_for W ON P.Pnumber = W.Pno
GROUP BY P.Pname;
GO

-- 3. Display the data of the department which has the smallest employee ID over all employees' ID.
SELECT D.*
FROM Employee E
JOIN Departments D ON E.Dno = D.Dnum
WHERE E.SSN = (SELECT MIN(E.SSN) FROM Employee E JOIN Departments D ON E.Dno = D.Dnum);
GO

-- 4. For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
SELECT 
	MAX(E.Salary) MAX_Salay,
	MIN(E.Salary) MIN_Salary,
	AVG(E.Salary) AVG_Salary,
	D.Dname
FROM Employee E
JOIN Departments D ON E.Dno = D.Dnum
GROUP BY D.Dname;
GO

-- 5. List the full name of all managers who have no dependents.
SELECT (Fname+' '+Lname) MGR_Full_Name
FROM Employee E
JOIN Departments D ON E.SSN = D.MGRSSN
WHERE D.MGRSSN NOT IN (SELECT ESSN FROM Dependent);
GO

-- 6. For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
SELECT D.Dnum, D.Dname, Low_Salary_Dep.Num_Of_Emp
FROM Departments D
JOIN (SELECT Dno, COUNT(SSN) Num_Of_Emp
		FROM Employee
		GROUP BY Dno
		HAVING AVG(Salary) < (SELECT AVG(Salary) FROM Employee)
) AS Low_Salary_Dep ON D.Dnum = Low_Salary_Dep.Dno;
GO

-- 7. Retrieve a list of employee’s names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.
SELECT E.Fname, E.Lname, P.Pname, E.Dno
FROM Employee E
JOIN Works_for W ON E.SSN = W.ESSn
JOIN Project P ON W.Pno = P.Pnumber
ORDER BY E.Dno, E.Lname, E.Fname;
GO

-- 8. Try to get the max 2 salaries using sub query
/*
SELECT MAX(Emp.Salary)
FROM (	SELECT Salary
		FROM Employee
		EXCEPT
		SELECT MAX(Salary) FROM Employee
	 ) AS Emp
GO
*/

SELECT MAX(Salary)
FROM Employee
WHERE Salary != (SELECT MAX(Salary) FROM Employee);
GO

-- 9. Get the full name of employees that is similar to any dependent name
SELECT (Fname+' '+Lname) AS FullName
FROM Employee
WHERE Fname+' '+Lname IN (
    SELECT Dependent_name
    FROM Dependent
);
GO

-- 10. Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
SELECT SSN, (Fname+' '+Lname) AS FullName
FROM Employee
WHERE EXISTS (
	SELECT ESSN FROM Dependent
	WHERE ESSN = SSN
);
GO

-- 11. In the department table insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
INSERT INTO Departments VALUES ('DEPT IT',100, 112233,'1-11-2006')

-- 12. Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager)
--	a. First try to update her record in the department table
UPDATE Departments
SET MGRSSN = 968574
WHERE Dnum = 100;
GO

--	b. Update your record to be department 20 manager.
UPDATE Departments
SET MGRSSN = 102672
WHERE Dnum = 20;
GO

--	c. Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
UPDATE Employee
SET Superssn = 102672
WHERE SSN = 102660;
GO

-- 13. Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
UPDATE Employee
SET Superssn = 102672
WHERE Superssn = 223344;
GO

UPDATE Departments
SET MGRSSN = 102672
WHERE MGRSSN = 223344
GO

DELETE FROM Works_for
WHERE ESSn = 102672
GO

DELETE FROM Dependent
WHERE ESSN = 223344
GO

-- 14. Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
UPDATE Employee
SET Salary = Salary*1.3
WHERE SSN = (
	SELECT SSN
	FROM Employee E
	JOIN Works_for W ON E.SSN = W.ESSn
	JOIN Project P ON W.Pno = P.Pnumber
	WHERE P.Pname = 'Al Rabwah'
);
GO