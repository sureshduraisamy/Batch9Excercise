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