--assigns same rank to tied values
--does not skip the number after tie
select ProductID, ProductName, Category, price,
DENSE_RANK() OVER (partition by Category order by price desc) as rank2
from Product;
