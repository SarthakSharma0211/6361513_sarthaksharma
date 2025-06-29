CREATE TABLE Employees (
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');

INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 50000.00, '2024-01-15'),
('Jane', 'Smith', 2, 70000.00, '2023-11-01');

-- step 1 : Create a Procedure to Get Employee Details by Department

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END

-- step 2 : Create Procedure to Insert a New Employee

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END

DROP PROCEDURE sp_InsertEmployee, sp_GetEmployeesByDepartment;

-- step 1 : SQL to Create the Stored Procedure

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END

-- step 2 : SQL query to select employee details based on a given DepartmentID

SELECT 
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
FROM 
    Employees
WHERE 
    DepartmentID = @DepartmentID;

SELECT 
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    JoinDate
FROM 
    Employees
WHERE 
    DepartmentID = 2;

-- step 3 : Create sp_InsertEmployee Stored Procedure

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;

EXEC sp_InsertEmployee
    @FirstName = 'Alice',
    @LastName = 'Johnson',
    @DepartmentID = 2,
    @Salary = 65000.00,
    @JoinDate = '2025-06-29';


