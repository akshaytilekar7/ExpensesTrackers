# EXPENSE TRACKER 

## Tracke you expense easily
## Report for montlhy and yealry overview
## Filter out Record for anlaysing 
## Easily drill down your expenditure and analysis on the same
## Export to excel functionality 

#### Windows form
#### UOW Pattern + Entity Framework + Generic Repository (.NET Core 3.1)
#### SQL server


#### framework and pattern
    * You have to setup your own connection string in appsettings.json file.
    * Open packahe manager console set default prroject to **WIN.project
        * Add-Migration InitialTables
        * Update-Database



    * In case of error "1L" 
            *   soln -  In EF Core 6, there are overloads for both Int32 and Int64 parameters of the UseIdentityColumns method.
                    In EF Core 5, there is only one for Int32. So as mentioned in the comments, you need to change 1L to simply 1.
            *   To solve error 	ALWAYS REPLACE 1L TO 1    
