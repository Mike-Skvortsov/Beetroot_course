create table Products
(
ID int identity(1,1) not null primary key,
Title varchar(30) not null,
Price float not null,
Category varchar(30) not null
);
alter table Products add Quantity int not null

insert into Products (Title, Price, Category, Quantity)
values ('iPhone', 1000, 'Smartphone', 10),
	   ('Samsung', 1500, 'Smartphone', 10),
	   ('Nokia', 700, 'Smartphone', 5),
	   ('Xiomi', 1800, 'Smartphone', 20),
	   ('Lenovo', 10000, 'laptop', 2),
	   ('Delphi', 2000, 'laptop', 8),
	   ('iPhone', 300, 'headphones', 100)
select * from Products


