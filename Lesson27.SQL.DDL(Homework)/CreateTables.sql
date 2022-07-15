create table PhoneBook
(
ID int identity(1,1) not null primary key,
Name varchar(30) not null,
Number varchar(12) not null,
Adress varchar(100)null
);

create table SchoolSchedule
(
ID int identity(1,1) not null primary key,
Weekday varchar(30) not null,
Class varchar(4) not null,
CountLessons tinyint not null,
Title varchar(30) not null,
NumberLesson varchar(12) not null,
);

create table UserLoginHistory
(
ID int identity(1,1) not null primary key,
IP varchar(15) not null,
Date DateTime not null,
Device varchar(40) not null,
Country varchar(30) not null,
Status bit not null
)

create table BankAccount
(
Title varchar(20) not null,
CountryCode tinyint not null,
Currency varchar(10) not null,
Bank varchar(20) not null,
OpeningDate DateTime not null,
ClosingDate DateTime not null
)

create table BankTransactions 
(
ID int identity(1,1) not null primary key,
Date DateTime not null,
TypeOfOperation varchar(20) not null,
Status bit not null,
)
