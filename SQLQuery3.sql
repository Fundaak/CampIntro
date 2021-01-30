--Select
Select ContactName Adi,
CompanyName SirketAdi,City from Customers


Select * from Customers where City = 'London'

Select * from Customers where City = 'Berlin'

--case intensive
select * from Products where categoryId=1 or categoryId=3
select * from Products where categoryId=1 or UnitPrice>-10
select * from Products order by UnitPrice desc
select * from Products where CategoryID=1 order by UnitPrice

select count(*) Adet from Products  where CategoryID=2

select CategoryId, count(*) from products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Product UnitPrice, Categories.CategoryName

from products inner join Catagories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10


select * from Products Left join [Order Details] od
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID

select * from Customers c left join orders o
on c.CustomerID = o.CustomerID
WHERE O.CustomerID is null

