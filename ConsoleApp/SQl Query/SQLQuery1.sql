use Batch9


--DML 1.Insert  2.update 3.delete
Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('karthick','karthick@7777','karthickkarthick065@gmail.com',7373236264,'new');

Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('ten','ten','ten@gmail.com',867473766,'new');

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
RegistrationId int identity(1,1) primary key,
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


--Create personDetail table
create table PersonDetail (
PersonDetailID  bigInt not null,AdhaarNumber bigint  not null unique,
PanNumber nvarchar(10) not null unique,RegsiterationId int not null foreign key REFERENCES 
registration(RegistrationId)
)
drop table PersonDetail ;
select * from PersonDetail
select * from registration
insert into  PersonDetail(PersonDetailID,AdhaarNumber,PanNumber,RegsiterationId ) values
(1,11555577111,'SDRFF2331F',3)

select * from
registration as R inner Join PersonDetail as PD  on R.RegistrationId=Pd.RegsiterationId
--where UserName='karthick'
--order By userName asc



select * from
registration as R  right outer  join  PersonDetail as PD  on R.RegistrationId=Pd.RegsiterationId

select * from
registration as R  left outer  join  PersonDetail as PD  on R.RegistrationId=Pd.RegsiterationId

select * from
registration as R  full outer  join  PersonDetail as PD  on R.RegistrationId=Pd.RegsiterationId

alter table registration add  salary bigint 

Update Registration set salary=19000 where UserName like'q%';
--case
select 
USERNAME,
CASE
when salary >= 20000 then 'top grade' 
when  salary > 15000 and salary <20000 then'middle grade' 
else 'low grade'
end as grade
from registration
--Delete from registration where username =''

select registrationid,username from registration union select RegsiterationId,panNumber from persondetail

select count(salary),salary from registration group by salary
select salary,username from registration group by salary,username having min(salary)>1
