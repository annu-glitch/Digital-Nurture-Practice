--create a procedure to count employees by department
CREATE PROCEDURE sp_CountEmployeesByDepartment (@department_ID INT)
AS
BEGIN
	SELECT COUNT(*) AS TotalEmployees
	FROM Employees
	WHERE DepartmentID = @department_ID;
END;

--prints message if procedure is built successfully
IF OBJECT_ID('sp_CountEmployeesByDepartment', 'P') IS NOT NULL
    SELECT 'Procedure created successfully' AS message;
ELSE
    SELECT 'Procedure does not exist' AS message;

--execute the procedure for a particular department
EXEC sp_CountEmployeesByDepartment 2;
