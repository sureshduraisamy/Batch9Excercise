--06-08-2024
--DML
--INsert
Insert into Registration
values('sureshkumar.durasiamy','Suresh@123','suresh@gmail.com',8754481205,'address')

Insert into Registration(UserName,Password,Email,MobileNumber,Address)
values('Zuresh','Suresh@123','suresh1@gmail.com',8754481205,'thoppampatti')

--Update 

update Registration
SET 
Password='hai@123'

update Registration
SET 
Password='hai@123',
MobileNumber=875463563
where UserName='sureshkumar.durasiamy' or MobileNumber=6778999
--Delete

Delete from Registration
where MobileNumber=8754481205



--DQL(Data Query Language)
Select * from Registration
Select UserName,Password from Registration

--07-08-2024
--DDL (Data Definition Query)
--Create,ALter,Drop,Truncate
--Create
--drop table Registration
--drop table persondetails
create table Registration
(
RegistrationID bigint not null identity(1,1) primary key,
Username nvarchar(100) not null unique,
Password nvarchar(20) not null,
Email nvarchar(100) not null unique,
MobileNumber bigint not null check(len(MobileNumber)=10),
Address nvarchar(300) null default ('Thoppampatti')
)
create table PersonDetails
(
PersonDetailsID bigint not null identity(1,1) primary key,
AdhaarNumber nvarchar(100) not null unique,
PANNumber nvarchar(20) not null unique,
RegistrationID bigint not null foreign key REFERENCES Registration(RegistrationId)
)
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
   UserName ='Suresh' and RegistrationID=5
--or
Select 
	UserName,Password 
from 
	Registration
where 
   UserName ='Suresh' or RegistrationID=5

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

--SUb Query 

select * from registration 
where 
username in ( select username from registration where email like 'S%_r' )

--COnstraints 
--Define a rule to the table to control the data values 

--TYpes 
--1. Not null - It wil not allow null values 
--2. Unique - It will not allowa the duplicate records and will allow only one null values 
--3. Primary Key - It will not allow duplicats and null vlues ( Not null + unique)
--4. Foreign Key - It is used to relate the records between the parent and child tables 
Select * from Registration
delete from Registration
select * from PersonDetails
delete from PersonDetails
--5. Check - Used to restorcy the data based on the Condition
--6. Default - Used to define the default value of the specific column
--7. Index - to speed up the data retrival process
--Alaias
select username as Name from registration