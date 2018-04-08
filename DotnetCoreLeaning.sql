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


*/