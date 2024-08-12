--06-08-2024
--DML
--INsert

Insert into Registration(UserName,Password,Email,address)
values('pranesh','kavi','pranes@134','palini')

--Update 

update Registration
SET 
username='narendra'

where UserName='pranesh' 

delete Registration
where email='panesh@123'


--DQL(Data Query Language)
Select * from Registration
--07-08-2024
drop table Registration
--DDL
--create
create table Registration
 ( RegestrationID bigint not null identity(1,1),
username nvarchar(100) not null,
password nvarchar(100) not null,
email nvarchar(100) not null,
address nvarchar(100)not null)

Insert into Registration(UserName,Password,Email,address)
values('pranesh','kavi','pranes@134','palini')

--Alter
Alter table Registration drop column address

Alter table Registration
add address nvarchar(300) not null default('address')
--truncate
truncate table Registration
--keyword
--top
     select top 10 * from Registration
	 --Logical operator
	 --and,or,not
	 select
	username,password 
	from
	Registration 
	where
	username='narendra'and RegestrationID =5
	--or
	select
	username,password 
	from
	Registration 
	where
	username='narendra'or RegestrationID =5
	--not
	select
	username,password 
	from
	Registration 
	where
	address is not null
	--in,between,link
	--in
	select
	username,password 
	from 
	Registration
	where
	RegestrationID in (1,2,3,4,5)
	--between
	select
	username,password 
	from
	registration 
	where
	RegestrationID  between 1 and 3
	
	--like
	select
	username,password 
	from Registration
	where
	username like '_a_i'
	--order by
	--asc
	select * from Registration 
	order by username desc
	--agreegate function
	--count,min,max,avg,sum
	select Count (*)from registration 
	select min(Registration) from Registration
	select max(Registration) from Registration
	select avg(Registration) from Registration
	select sum(Registration) from Registration