create table Book (
Id int primary key identity (1, 1) not null,
Title varchar(50) not null,
AutorId int foreign key (AutorId) references Autor(ID) not null)

create table Autor (
Id int primary key identity (1, 1) not null,
Name varchar(50) not null)

create table Customer (
Id int primary key identity (1, 1) not null,
Name varchar(50) not null)

create table HistoryBook(
Id int primary key identity (1, 1) not null,
BookID int foreign key (BookID) references Book(ID) not null,
CustomerID int foreign key (CustomerID) references Customer(ID) not null,
Time DateTime not null)

create table CountBook(
Id int primary key identity (1, 1) not null,
BookID int foreign key (BookID) references Book(ID) not null,
Count int not null)