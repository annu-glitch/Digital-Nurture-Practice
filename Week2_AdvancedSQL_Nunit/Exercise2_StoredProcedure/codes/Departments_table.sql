--create Departments table

create table Departments(
	DepartmentID INT PRIMARY KEY,
	DepartmentName VARCHAR(100)
);

--insert values into Departments table
INSERT INTO Departments
values
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');
