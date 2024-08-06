--DQL select
Select * from Registration;
Select * from Registration where UserName='karthick';
Select UserName from Registration;

--DML 1.Insert  2.update 3.delete
Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('karthick','karthick@7777','karthickkarthick065@gmail.com',7373236264,'new');

Insert into Registration(UserName,password,Email,MobileNumber,address) 
values ('karthick.S','karthick@7777','karthickkarthick065@gmail.com',7373236264,'new');

Update Registration set Address='odc' where UserName='karthick';
Update Registration set Address='odc',MobileNumber=9965654725 where UserName='karthick';

Delete from Registration  where UserName='karthick.s';
