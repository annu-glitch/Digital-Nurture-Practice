--create a procedure to insert a new record in Employees table
CREATE PROCEDURE sp_InsertEmployees
	(@EmployeeID INT,
	@FirstName VARCHAR(50),
	@LastName VARCHAR(50),
	@DepartmentID INT,
	@Salary DECIMAL(10, 2),
	@JoinDate DATE)
AS
BEGIN
	INSERT INTO Employees(EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
	VALUES (@EmployeeID, @FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;

--execute procedure
EXEC sp_InsertEmployees 5, 'Annu', 'Priya', '3', '78000.56', '2025-08-29';
EXEC sp_InsertEmployees 6, 'Arpit', 'Anand', '2', '78000.56', '2022-08-29';

