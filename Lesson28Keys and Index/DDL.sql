create table Products(
Id int primary key identity (1,1) not null,
CategoryID int not  null,
Title varchar(30) not null,
Price real not null)

create table Customer(
Id int primary key identity (1,1) not null,
Name varchar(30) not null)

create table Orders(
Id int primary key identity (1,1) not null,
CustomerID int foreign key references Customer(ID) not null,
DeliveryMethod varchar(30))

create table OrderItems(
Id int primary key identity (1,1) not null,
ProductID int foreign key references Products(ID) not null,
Count int not null)
							
alter table OrderItems add OrderID int not null
alter table OrderItems add foreign key (OrderID) references Orders(ID)

alter table Products
add foreign key (CategoryID) references Category(ID)