# EXPENSE TRACKER 

## Track your expense easily
## Report for monthly and yealry overview
## Filter out Record for analysis 
## Easily drill down your expenditure for analysis
## Export to excel functionality 

#### Windows Form
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
