select Category,count(*) as Count, SUM(Price) as TotalPrice  from Products
group by Category

select * from Products ORDER BY Title

select Title, sum(Quantity*Price) as Profit
from Products
group by title
order by Profit desc

alter table Products add Rate float;
update Products set Rate = 0.78
update Products set Price = Price*Rate

