--06-08-2024
Insert into Registration
Values('Giri','Giri@123','giri@gmail.com',987654321,'adress')

Insert into Registration(UserName,Password,Email,MobileNumber)
values('hari','Hari@123','hari@gmail.com',984567236)

Insert into Registration(UserName,Password,Email,MobileNumber)
values('mari','mari@123','mari@gmail.com',9878645378)

update Registration
SET 
Password='Hai@123'
where UserName='hari'

Delete from Registration
Where Username='jwgfiu'

Select * from Registration
drop table Registration
truncate table registration

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
create table PersonDetails
(
PersonDetailsID bigint not null identity(1,1),
PanNumber varchar(13) not null unique,
AadhaarNumber bigint not null unique,
RegistrationID bigint not null
)
select * from persondetails
drop table PersonDetails


Insert into persondetails (PanNumber,Aadhaarnumber,RegistrationId)
values  ('HUJIY8798J',9867895876849,1)
insert into persondetails (PanNumber,Aadhaarnumber,RegistrationId)
values('JNYFJ5467J',9876789056,2)
select* from Registration r inner join persondetails pd on r.registrationID = pd.registrationid
select* from Registration r left outer join persondetails pd on r.registrationID = pd.registrationid
select* from Registration r right outer join persondetails pd on r.registrationID = pd.registrationid
select* from Registration r full outer join persondetails pd on r.registrationID = pd.registrationid
order by username asc