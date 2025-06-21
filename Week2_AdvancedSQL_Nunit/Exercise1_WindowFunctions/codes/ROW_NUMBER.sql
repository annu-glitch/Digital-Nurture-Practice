--assigns unique ranks

select ProductID, ProductName, Category, price,
ROW_NUMBER() OVER (partition by Category order by price desc) as unique_rank
from Product;
