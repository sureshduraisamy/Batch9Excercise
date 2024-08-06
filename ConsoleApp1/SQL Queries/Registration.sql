--06-08-2024
Insert into Registration
Values ('Vignesh','vignesh@123','Vignesh@gmail.com',8754481205,'address')

Insert into Registration(UserName,Password,Email,MobileNumber)
values('kong','vignesh@123','Vignesh@gmail.com',8754481205)

update Registration set Password='viky@123' where UserName='kong'

--DQL(Data Query Language)
Select * from Registration
Select UserName,Password from Registration
