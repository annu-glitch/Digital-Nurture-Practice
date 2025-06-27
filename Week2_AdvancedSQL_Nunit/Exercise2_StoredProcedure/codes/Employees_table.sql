--create Employees table
create table EMPLOYEES(
	EmployeeID INT PRIMARY KEY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
	Salary DECIMAL(10,2),
	JoinDate DATE
);

--insert values into Employees table
INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary,
JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'), 
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');
