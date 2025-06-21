--handling tied ranks
--assigns rank to tied values
--skips the next number after tied value
select ProductID, ProductName, Category, price,
RANK() OVER (partition by Category order by price desc) as rank1
from Product;
