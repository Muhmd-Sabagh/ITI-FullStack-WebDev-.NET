-- PART-02 QUERIES ON AdventureWorks2012 DB

-- Helper Queries
USE AdventureWorks2012

-- Display all schemas
SELECT name AS SchemaName
FROM sys.schemas
WHERE principal_id = 1;

-- Display all table in a schema
SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'HumanResources'; -- dbo, HR, Person, Production, Purchasing, Sales

-- Display all columns in a table
SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = 'HumanResources' AND TABLE_NAME = 'Employee';

-- 1. Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) to show SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
-- (27,870rows)
SELECT SalesOrderID, ShipDate
FROM Sales.SalesOrderHeader
WHERE ShipDate BETWEEN '7/28/2012' AND '7/29/2014';
GO

-- 2. Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
-- (317rows)
SELECT ProductID, Name
FROM Production.Product
WHERE StandardCost < 110
GO

-- 3. Display ProductID, Name if its weight is unknown
-- (299rows)
SELECT ProductID, Name
FROM Production.Product
WHERE Weight IS NULL;
GO

-- 4. Display all Products with a Silver, Black, or Red Color
-- (174rows)
SELECT ProductID, Name
FROM Production.Product
WHERE Color IN ('Silver', 'Black', 'Red');
GO

-- 5. Display any Product with a Name starting with the letter B
-- (4rows)
SELECT ProductID, Name
FROM Production.Product
WHERE Name LIKE 'B%';
GO

-- 6. Run the following Query
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3;
-- Then write a query that displays any Product description with underscore value in its description.
-- (1row)
SELECT Description
FROM Production.ProductDescription
WHERE Description LIKE '%\_%' ESCAPE '\';
GO

-- 7. Calculate sum of TotalDue for each OrderDate in Sales.SalesOrderHeader table for the period between  '7/1/2001' and '7/31/2014'
-- (1,124rows)
SELECT SUM(TotalDue) AS SUM_OF_Dues, OrderDate
FROM Sales.SalesOrderHeader
WHERE OrderDate BETWEEN '7/1/2001' AND '7/31/2014'
GROUP BY OrderDate;
GO

-- 8. Display the Employees HireDate (note no repeated values are allowed)
-- (164rows)
SELECT DISTINCT HireDate
FROM HumanResources.Employee;
GO

-- 9. Calculate the average of the unique ListPrices in the Product table
-- (1row)
SELECT AVG(ListPrice)
FROM Production.Product;
GO

-- 10. Display the Product Name and its ListPrice within the values of 100 and 120 the list should has the following format "The [product name] is only! [List price]" (the list will be sorted according to its ListPrice value)
-- (6rows)
SELECT Name [Product Name], ListPrice [List Price]
FROM Production.Product
WHERE ListPrice BETWEEN 100 AND 120
ORDER BY ListPrice;
GO

-- 11.	a) Transfer the rowguid ,Name, SalesPersonID, Demographics from Sales.Store table  in a newly created table named [store_Archive]
--		Note: Check your database to see the new table and how many rows in it?
-- (701rows)
SELECT rowguid, Name, SalesPersonID, Demographics
INTO Store_Archive
FROM Sales.Store;
GO

SELECT * FROM Store_Archive;
GO

--		b)	Try the previous query but without transferring the data? 
-- (0rows)
SELECT rowguid, Name, SalesPersonID, Demographics
INTO Store_Archive_Metadata
FROM Sales.Store
WHERE 1=2;
GO

SELECT * FROM Store_Archive_Metadata;
GO

-- 12. Using union statement, retrieve the today’s date in different styles using convert or format funtion.
-- (5rows)
SELECT CONVERT(varchar, GETDATE(), 101) AS DifferentStylesDate
UNION
SELECT CONVERT(varchar, GETDATE(), 106)
UNION
SELECT CONVERT(varchar, GETDATE(), 111)
UNION
SELECT FORMAT(GETDATE(), 'dd-MM-yyyy')
UNION
SELECT FORMAT(GETDATE(), 'MMMM dd, yyyy')
GO