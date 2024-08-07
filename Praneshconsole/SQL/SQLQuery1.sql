--06-08-2024
--DML
--INsert

Insert into Registration(UserName,Password,Email)
values('pranesh','kavi','pranes@134','palini')

--Update 

update Regestration
SET 
username='narendra'

where UserName='pranesh' 

delete Regestration 
where email='panesh@123'


--DQL(Data Query Language)
Select * from Registration
--07-08-2024
drop table Regestration
--DDL
--create
create table registration
 ( RegestrationID bigint not null identity(1,1),
username nvarchar(100) not null,
password nvarchar(100) not null,
email nvarchar(100) not null,
addres nvarchar(100)not null)

Insert into Registration(UserName,Password,Email,addres)
values('pranesh','kavi','pranes@134','palini')

--Alter
Alter table registration drop column addres

Alter table registration 
add addres nvarchar(300) not null default('address')
--truncate
truncate table registration
--keyword
--top
     select top 10 * from registration 
	 --Logical operator
	 --and,or,not
	 select
	username,password 
	from
	registration 
	where
	username='narendra'and RegestrationID =5
	--or
	select
	username,password 
	from
	registration 
	where
	username='narendra'or RegestrationID =5
	--not
	select
	username,password 
	from
	registration 
	where
	address is not null
	--in,between,link
	--in
	select
	username,password 
	from 
	registration
	where
	RegestrationID in (1,2,3,4,5)
