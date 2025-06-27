--create a procedure to get Employee details by department id

CREATE PROCEDURE sp_GetEmployeesByDepartments (@department_id INT)
AS
BEGIN
	SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
	from Employees
	where DepartmentID = @department_id;
END;

--Execute the procedure
select 'Details of employees in department 2' as message;
exec sp_GetEmployeesByDepartments @department_id = 2;
