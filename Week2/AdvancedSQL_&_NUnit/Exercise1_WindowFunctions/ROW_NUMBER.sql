--ROW_NUMBER() to assign unique ranks within each category

select ProductID, ProductName, Category, price,
ROW_NUMBER() OVER (partition by Category order by price) as unique_rank
from Product;
