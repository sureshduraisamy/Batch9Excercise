
--6/8/2024
--data manipulation language 

Insert into Registration
values('Naveenkumar','naveen123',8610026900,'naveenkumarpnk203@gmail.com','coimbatore')

insert into Registration(UserName,PassWord,MobileNumber,Email,Address)
values('magesh','magesh123',9787712400,'naveen@gmail.com',null)
insert into Registration(UserName,PassWord,MobileNumber,Email,Address)
values('harsha','magesh123',9787712400,'naveen@gmail.com',null)

update Registration
set
UserName = 'naveenkumar',
PassWord = 'naveen203',
mobilenumber = 9943399904
where Address = 'coimbatore'


delete from Registration
where MobileNumber=8610026900


--Data query language
select * from Registration
select username,password from Registration

--7/8/2024
--DDl(create,alter,drop,truncate)

--drop table 
drop table Registration

--create table 
create table registration
(
registrationid bigint not null identity (1,1),
username nvarchar(100) not null,
password nvarchar(20) not null,
mobilenumber bigint not null,
email nvarchar(150) not null,
address nvarchar(300) null
)
insert into registration(username,password,mobilenumber,email,address)
values('naveen','naveen123',8610026900,'naveen2gmail',null)
insert into registration(username,password,mobilenumber,email,address)
values('harsha','magesh123',9787712400,'naveen@gmail.com',null)
insert into registration(username,password,mobilenumber,email,address)
values('pranesh','pranesh123',9787712400,'pranesh@gmail.com',null)

--alter drop
alter table Registration
drop column address
--alter add
alter table registration
add  address nvarchar(300) not null default('address')
--alter-alter
alter table registration
alter column address nvarchar(200)
--truncate
truncate table registration

--update 
update Registration
set 
address = 'coimbatore'
where username='naveen'



--Data query language
select * from Registration

--keywords
--top 
select top 2 *from Registration

--logical operator 
--and 
select
* 
from 
registration
where
username = 'naveenkumar' and address = 'coimbatore'
--or
select 
username 
from registration
where
username ='pranesh' or address='coimbatore'
--not 
select 
*
from
registration
where 
address is not null
--in like between
select *
from registration
where 
registrationid  not in (1,2,3)
--between
select *
from registration
where registrationid between 2 and 5
--like
select *
from registration
where username like 'n__ee_%'

