-- Dot--
-- Date April 08 2018 
/*
https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

1. learning items. 
- solution and projects files are two diffrent kind of files. 
-- In dotnet core sln file created using dotnew new sln command --> file will automatically take name of folder if no arugument provideds 
-- alwasys put solution file in main folder 
-- create new folder using mkdir command for diffrent projects if you want to add more than one project 
-- otherwide you can have solution file in same folder as cs proj. 


2. -- adding multiple cs project files and add them inside the one solution 
-- create new folders according to name of project 
-- run dotnet core new command in each folder 
-- adding dotnet new -- projecttype --> Like mvc , cli , unittesting or other kind of projects 

3. add projects inside the solution file
dotnet sln todo.sln add todo-app/todo-app.csproj
working command example : dotnet sln cleaningCoreapp.sln add cleaningsoftunittesting/CleaningSoftUnitTesting.csproj
3.1 add projects to solution file using defining directory path and .csproj file. 
- Need to provide an attention that at givan path .cs proj file is located

4. dotnet build will build all the projects mentioned in solution...--> it will not run project if you have only solution fiel in main application directory
-- it will give you an error no csproj files inside the folder. 
-- Dotnet build inthe directory where .sln file located will build all the project.

5. To run a project from specific directory without moving to that directory you can use 
-- dotnet run --project cleaningsoftWebApp/ 0r dotnet run -project cleaningsoftWebApp/
withoud moving to particular directory you can run the whole command.

-- you can not run same csproj file from same machine using diffent terminals gives error and closed unexpectedly.
*/

/*
Install EF core on mac
1. go to the csproj directory and run ef core nuget commmand 
-- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
-- Use above command wher you wnts to add package in the folder with project file.
-- Above command will Install entityframeowork core on mack and will provie details-- in uses nuget package


2. to use dotnet ef command on CLI need to add cli itergrop entry for cli project on efcore
2.1 please add following entry inside the .csproj file where you are planning to run EFCore. 
<ItemGroup>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
</ItemGroup>
-- Item group entry makes clic command working in csproj files.
*/

/*
3. Run dotnet add package Microsoft.EntityFrameworkCore.Design

4. Run dotnet restore
5. Password with ! will not  work in efcore run argument 
USE CleaningSoftwareLogic;


CREATE LOGIN dev   
    WITH PASSWORD = 'Dcs1989..';  
GO  
--- Succesfulll query to create usernaem and password and providing permission to the user in sql --
-- CREATE LOGIN dev2   
--     WITH PASSWORD = 'Dcs1989..';  
--     CREATE USER dev2 FOR LOGIN dev2;  
-- GO   

USE CleaningSoftwareLogic
CREATE USER dev2 FOR LOGIN dev2

EXEC sp_addrolemember N'db_owner', N'dev2'
*/
/*
dotnet ef dbcontext scaffold "Server=localhost;Database=CleaningSoftwareLogic;User ID=dev2;Password=Dcs1989.." Microsoft.EntityFrameworkCore.SqlServer -o Model
*/

-- below command will no work in password ! mark creates an erro
--dotnet ef dbcontext scaffold "Server=localhost\;Database=CleaningSoftwareLogic;User ID=sa;Password=Dcs1989..!" Microsoft.EntityFrameworkCore.SqlServer -o Model

/*
6.
-- Final working command with overide
-- dotnet ef dbcontext scaffold "Server=localhost;Database=CleaningSoftwareLogic;User ID=dev2;Password=Dcs1989.." Microsoft.EntityFrameworkCore.SqlServer -o Model -f
*/