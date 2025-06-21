--CREATING TABLE Product
create table Product (
	ProductID int primary key,
	ProductName varchar(50),
	Category varchar(50),
	price int not null
);

--INSERTING VALUES INTO Product
INSERT INTO Product (ProductID, ProductName, Category, price) VALUES
(1, 'Smartphone X', 'Electronics', 699),
(2, 'Laptop Pro', 'Electronics', 1299),
(3, 'Bluetooth Speaker', 'Electronics', 149),
(4, 'LED TV', 'Electronics', 1299),
(5, 'T-shirt', 'Clothing', 25),
(6, 'Jeans', 'Clothing', 40),
(7, 'Jacket', 'Clothing', 100),
(8, 'Sneakers', 'Clothing', 100),
(9, 'Novel A', 'Books', 15),
(10, 'Textbook B', 'Books', 85),
(11, 'Cookbook C', 'Books', 45),
(12, 'Doll House', 'Toy', 1299),
(13, 'Teddy Bear', 'Toy', 1299);
