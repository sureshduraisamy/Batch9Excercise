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




