 --06-08-24
 Insert into Registration(UserName,Password,Email,MobileNumber)
 values('kavi','msd','kavi msd',1234567890)
Insert into Registration(UserName,Password,Email,MobileNumber) 
  values('ajith','hai','ajith',0987654321)

  update Registration
  set
	 UserName='kavivarman'
	 where UserName='kavi'

	--Delete 
	  delete from Registration
	  where UserName='ajith'

  --DQL(Data Query Language)

	Select * from Registration
	  select UserName,Password from Registration

--07-08-2024
--DDL (Data Definition Query)
--Create,ALter,Drop,Truncate
--Create
create table registration
(
 registrationID bigint not null identity(1,1),
 UserName nvarchar(100) not null,
 password nvarchar(20) not null,
 Email nvarchar(100) not null,
 MobileNumber bigint not null,
 Address nvarchar(300) null
)
--Drop
drop table 	 registration
--Alter	  Drop
alter table registration
drop column Address
--Alter add
alter table registration
Add Address nvarchar(100) null
--Alter alter
alter table registration
alter column Address varchar(200)
--Truncate
Truncate table registration
--keywords
--top
	  select top 10 * from registration
   --LOgical operatior 
--and, or ,not
Select 
	UserName,password
from 
	Registration
where 
   UserName ='kavi' and registrationID=5
--or
Select 
	UserName,password
from 
	Registration
where 
   UserName ='kavi' or RegistrationID =5
	--not
	Select 
	UserName,password
from 
	Registration
where 
  Address is not null
  --In, between , like
--IN
	 Select 
	UserName,password
from 
	Registration
where 
    registrationID  in (1,2,3,4,5)
--between
 Select 
	UserName,password
from 
	Registration
where 
    registrationID  between 1 and 3
 --like
  Select 
	UserName,password
from 
	Registration
where 
   username  like '_a_i'

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
select max(registrationID) from registration
select avg(registrationID) from registration
select sum(registrationID) from registration

--joins
create table PersonDetails
(
 PersonDetailsID bigint not null identity(1,1),
 Aadhaar bigint not null,
 PanNumber varchar(20) not null,
 registrationID bigint not null 
 
)
drop table 	PersonDetails
Select * from Registration
Select * from  PersonDetails

 Insert into Registration(UserName,Password,Email,MobileNumber)
 values('kavi','msd','kavi msd',1234567890)
Insert into Registration(UserName,Password,Email,MobileNumber) 
  values('ajith','hai','ajith',0987654321)
 Insert into Registration(UserName,Password,Email,MobileNumber)
 values('vijay','vj','vijayvj',1234509876)
Insert into Registration(UserName,Password,Email,MobileNumber) 
  values('sam','sams','sam@gamil',0987651234)

  insert into PersonDetails(Aadhaar,PanNumber,registrationID)
  values(12345678901,'kavi123',1)
  insert into PersonDetails(Aadhaar,PanNumber,registrationID)
  values(09876543210,'ASDHFJJ234R',2)
	 --	inner join
	 select
	 	*
		from
		registration as r inner join persondetails as pd on r.registrationID=pd.registrationID
		where
		r.UserName='kavi'
  --left outer join
   select
	 	*
		from
		registration as r left outer join persondetails as pd on r.registrationID=pd.registrationID
  --right join
   select
	 	*
		from
		registration as rs right join persondetails as pd on r.registrationID=pd.registrationID
	--outer join
	 select
	 	*
		from
		registration as r full outer join persondetails as pd on r.registrationID=pd.registrationID
		
		
		

		
