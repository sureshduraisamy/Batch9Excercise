use Batch9


--DML 1.Insert  2.update 3.delete
Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('karthick','karthick@7777','karthickkarthick065@gmail.com',7373236264,'new');

Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('karthick.S','karthick@7777','karthickkarthick065@gmail.com',7373236264,'new');

Update Registration set Address='odc' where UserName='karthick';
Update Registration set Address='odc',MobileNumber=9965654725 where UserName='karthick';

Delete from Registration  where UserName='karthick.s';

--DQL select
Select * from Registration;
Select * from Registration where UserName='karthick';
Select UserName from Registration;

--DDl
--create
create table registration (
RegistrationId int identity(1,1),
UserName nvarchar(100),
Password varchar(20),
Email varchar(150),
MobileNumber bigint not null,
Address nvarchar(150)  null );
--drop
Drop table Registration;

--truncate
truncate table registration;

--alter drop
Alter table Registration
drop  column address;

--alter add
Alter table Registration
add  address nvarchar(150) not null default('address');

--alter alter
Alter table Registration
alter column userName varchar(100) not null; 

----Keywords
--top
select top 10 * from registration;

--LOgical operatior 
--and, or ,not
Select 
	UserName,Password  from Registration
where 
   UserName ='karthick' and RegistrationID=1

   Select 
	UserName,Password  from Registration
where 
   UserName ='karthick' or RegistrationID=2

   --not
   Select 
	UserName,Password  from Registration
where 
    RegistrationID  not in (0,1);

	   Select 
	UserName,Password,RegistrationId  from Registration
where 
    RegistrationID  not between 0 and 1;

--Like
Select 
	UserName,Password 
from 
	Registration
Where username like 'k%'

--_
Select 
	UserName,Password 
from 
	Registration
Where username like 'k_r_%'

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


