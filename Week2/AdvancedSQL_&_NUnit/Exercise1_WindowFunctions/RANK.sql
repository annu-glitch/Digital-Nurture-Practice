--handling tied values
--gives same rank to tied values
--skips next number after a tie

select ProductID, ProductName, Category, price,
RANK() OVER (partition by Category order by price desc) as rank1
from Product;
