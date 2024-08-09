--06-08-2024
--DML
--INsert
Insert into Registration
values('vicky','vicky@123','vignesh@gmail.com',8754481205,'address')

Insert into Registration(UserName,Password,Email,MobileNumber)
values('vicky','vicky@123','vignesh@gmail.com',8754481205)

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