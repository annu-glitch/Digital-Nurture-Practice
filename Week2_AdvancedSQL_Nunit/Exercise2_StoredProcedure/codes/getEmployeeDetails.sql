--create a procedure to get Employee details by department id

CREATE PROCEDURE sp_GetEmployeesByDepartments (@department_id INT)
AS
BEGIN
	SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
	from Employees
	where DepartmentID = @department_id;
END;

--Execute the procedure
exec sp_GetEmployeesByDepartments @department_id = 2;
