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
where MobileNumber=9943399904


--Data query language
select * from Registration
select username,password from Registration