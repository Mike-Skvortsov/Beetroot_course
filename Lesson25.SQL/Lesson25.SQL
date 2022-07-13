select * from Persons

select * from Persons where Gender = 'F'

select * from Persons order by Age

select top 1 * from Persons order by Age desc
select top 1 * from Persons
where Gender = 'F'
order by Age desc

delete from Persons where Id = 4

update Persons set Age = 17 where FirstName = 'Olena'

select count(*) from Persons

select Gender, count(*) as Count from Persons 
group by Gender

select * from Persons where Age > (select AVG(Age) from Persons)

insert into Persons (FirstName, LastName, Age, Gender)
Select FirstName, LastName, Age, Gender from Persons

insert into Persons (FirstName, LastName, Age, Gender)
values('Vova', 'Radchenko', 24, 'M')

select FirstName, count (*) from Persons
group by FirstName
having count(*) > 1

