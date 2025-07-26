-- creating a stored procedure as sp_GetEmployeeCountByDepartment

CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT 
        COUNT(*) AS TotalEmployees
    FROM 
        Employees
    WHERE 
        DepartmentID = @DepartmentID;
END;

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 1;
