Open packahe manager console
	set default prroject to **WIN.project

run
	select project -> core
		Add-Migration ExpectedAmount
		Add-Migration InitialData
		Update-Database

	Manually add data to User and Bank tables


in case of error "1L" 
soln -  In EF Core 6, there are overloads for both Int32 and Int64 parameters of the UseIdentityColumns method.
		In EF Core 5, there is only one for Int32. So as mentioned in the comments, you need to change 1L to simply 1.

to solve error
	ALWAYS REPLACE 1L TO 1


	
	Add-Migration UserTable