--06.08.2024
Insert into Registration
Values('Vikram','@vikram421','vikram@mail.com',6383500480,'Address')
Insert into Registration(UserName,Password,Email,MobileNumber)
Values('Gokul','@Gokul421','gokul@gmail.com',8970765443)

--Update
update Registration
SET
Password='hai@123'

update Registration
SET 
Password='hai@123',
MobileNumber=875463563
where UserName='Vikram' or MobileNumber=6383500480

--Delete
Delete from Registration
where MobileNumber=8754481205

Select * from Registration
--07-08-2024
--DDL (Data Definition Query)
--Create,ALter,Drop,Truncate
--Create


create table Registration
(
RegistrationID bigint not null identity(1,1),
Username nvarchar(100) not null,
Password nvarchar(20) not null,
Email nvarchar(100) not null,
MobileNumber bigint not null,
Address nvarchar(300) null
)
drop table Registration
--Drop
drop table Registration
--Alter - drop
Alter table Registration
drop column address
--alter - add
Alter table Registration
add address nvarchar(300) not null default('address')
--Alter - alter
alter table registration
alter column address varchar(200)
--Truncate
truncate table registration
----Keywords
--top
select top 10 * from registration
--LOgical operatior 
--and, or ,not
Select 
	UserName,Password 
from 
	Registration
where 
   UserName ='Vikram' and RegistrationID=5
--or
Select 
	UserName,Password 
from 
	Registration
where 
   UserName ='vikram' or RegistrationID=5

-- Not
Select 
	UserName,Password 
from 
	Registration
where 
   address is not null
--In, between , like
--IN
Select 
	UserName,Password 
from 
	Registration
where 
   RegistrationId  not in (1,2,3,4,5)
--Between
Select 
	UserName,Password 
from 
	Registration
where 
   RegistrationId not between 5 and 10
--Like
Select 
	UserName,Password 
from 
	Registration
Where username like 'r%r'
--_
Select 
	UserName,Password 
from 
	Registration
Where username like 'r_s_%'
--Order by
--asc
select * from registration
order by username asc

select * from registration
order by username desc

--Agreegate FUnction
--count,min,max,avg,sum
select COUNT(*) from registration
select Min(registrationID) from registration
select Max(registrationID) from registration
select Avg(registrationID) from registration
select sum(registrationID) from registration





