-- PART-02 CONSTRAINS

-- Create the database
CREATE DATABASE CenterDB;
GO

-- Using the databse
USE CenterDB;
GO

-- Instructor Table
CREATE TABLE Instructor (
	ID INT PRIMARY KEY IDENTITY(1,1),
	Fname VARCHAR(50) NOT NULL,
	Lname VARCHAR(50) NOT NULL,
    BD DATE,
    Age AS (YEAR(GETDATE()) - YEAR(BD)),  -- Calculated attribute
    Address VARCHAR(50),
    Salary DECIMAL(10,2) DEFAULT 3000,
    Overtime DECIMAL(10,2) UNIQUE,
    NetSalary AS (Salary + Overtime) PERSISTED,      -- Calculated attribute
    Hiredate DATE DEFAULT GETDATE(),

	CONSTRAINT Check_Address CHECK (Address IN ('cairo', 'alex')),
	CONSTRAINT Check_Salary CHECK (Salary BETWEEN 1000 AND 5000)
);
GO


-- Course Table
CREATE TABLE Courses (
    CID INT PRIMARY KEY IDENTITY(1,1),
    Cname VARCHAR(50) NOT NULL,
    Duration INT UNIQUE
);
GO

-- Teaching Table
CREATE TABLE Teaching (
    IID INT,
    CID INT,
    CONSTRAINT PK_Teaching PRIMARY KEY (IID, CID),
    CONSTRAINT FK_Teaching_Instructor FOREIGN KEY (IID) 
        REFERENCES Instructor(ID) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_Teaching_Courses FOREIGN KEY (CID) 
        REFERENCES Courses(CID) ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Lab Table
CREATE TABLE Lab (
    LID INT,
    CID INT NOT NULL,
    Location VARCHAR(50),
    Capacity INT,

	CONSTRAINT Check_Capacity CHECK (Capacity < 20),
    CONSTRAINT PK_Lab PRIMARY KEY (LID, CID),
    CONSTRAINT FK_Lab_Courses FOREIGN KEY (CID) 
        REFERENCES Courses(CID) ON DELETE CASCADE ON UPDATE CASCADE
);