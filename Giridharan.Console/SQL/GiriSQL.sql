--06-08-2024
Insert into Registration
Values('Giri','Giri@123','giri@gmail.com',987654321,'adress')

Insert into Registration(UserName,Password,Email,MobileNumber)
values('hari','Hari@123','hari@gmail.com',984567236)

update Registration
SET 
Password='Hai@123'
where UserName='hari'

Delete from Registration
Where MobileNumber=987654321

Select * from Registration

--07-08-2024
create table Registration
(
RegistrationID bigint not null identity(1,1),
Username nvarchar(100) not null ,
Password nvarchar(20) not null,
Email nvarchar(150) not null,
MobileNumber bigint not null,
Adress nvarchar(300) null
)

Drop table Registration

Alter table Registration
drop column Adress

Alter table Registration
add address nvarchar(300) not null default('address')

alter table registration
alter column username varchar(200) not null

truncate table registration

Select 
	Username,Password 
from 
	Registration
where 
   Username ='Giri' and RegistrationID=1

   Select 
	UserName,Password 
from 
	Registration
where 
   UserName ='Hari' or RegistrationID=5

   Select 
	UserName,Password 
from 
	Registration
where 
   RegistrationId between 1 and 5

   Select 
	UserName,Password 
from 
	Registration
Where username like '__r%'

select * from registration
order by username asc