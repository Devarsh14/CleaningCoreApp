
-- Query to break foreign key relationship inside the table
while(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
begin
	declare @sql nvarchar(2000)
	SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
	+ '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
	FROM information_schema.table_constraints
	WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
	exec (@sql)
end
-- How can best practices with sql can be co-operated with dotnet core 
-- Main Aim here is to Create an applicaiton which helps me to Understand concepst s
-- Ticketing system for cleaning services 
-- Monitor live issues 
-- if same complain from same area comes again and again than it becomes issue and supervisor need to visit a system during cleanign working hour -- and describe the cleaner whats going wrong 
-- stock utitility counting from clearn perspective 
-- restock cleaning material once coming to complete 
-- In long run predicte how much stock user consume on site with services 

-- Provide cleaner a feed back 
-- cleanin score 
-- Proactive cleanign 
-- divide building in areas 
-- provide more attention to the area if same kind of complain is repetitive 
-- define complain nature 
-- How can we define and quantify cleaners efforrt ...

-- Automatic resolution send email facility to client 
-- provide real time tracking of issue 

-- priority of issue 
-- severity of issue 
-- New issue added


-- How organisation can help cleaner to understand issue 


-- Docker command user to create schema using Make 
-- Docker can be helpful in releasing database and tesing on various environment 
--- Docker image with Business logic can be created and shipped to various server on cusomter according to their need and scale 
-- School managment system -- same emage multiple container -- multitenant with unique database for each clienr -- with on file data

-------------
--sudo docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=Dcs1989..!'    -p 1433:1433 --name devarshCleaningSoftwareimg  -d microsoft/mssql-server-linux:2017-latest
--------


-- Docker start container name 
-- docker ps -a
-- docker image ls 
-- Working docker image command 

-- pull docker image
-- run docker image --
-- provide strong password and -- name is a container name 
--connect with sql operations studio 
-- localhost -- sa user name 

--- Creat a new DataBase --
-- Cleaning software logic seats in this database 
-- multi schme 
-- in Future can be multidatabase like -- diffrent database -- for example useage of azure vertical query from two diffrent kind of database 
-- Like Managment -- Operations two databases and query can be done using them 
-- learned usage of ssis -- in visual studion to transfer data

-- create database [CleaningSoftwareLogic]
-- USE   CleaningSoftwareLogic
/*
drop TABLE Cleaning_Service_Type
DROP TABLE Cleaning_Service_Providers

*/
-- Name of Cleaning company and which  kind of services one cleaning company can provide to the customer 
-- Many cleaning company can provide multiple services to the customer 
-- IF OBJECT_ID('dbo.Cleaning_Service_Providers', 'U') IS NOT NULL 
--   DROP TABLE dbo.Cleaning_Service_Providers;
-- create table [Cleaning_Service_Providers]
-- (
--    --NAME OF SOFTWARE PRODUCT 
--      [Id] UNIQUEIDENTIFIER NOT NULL
--    ,Company_Name nvarchar(300) 
-- )
-- ALTER TABLE [Cleaning_Service_Providers] add  CONSTRAINT Cleaning_Service_Providers_ID DEFAULT  NEWSEQUENTIALID () for ID
-- ALTER TABLE Cleaning_Service_Providers ADD CONSTRAINT PK_Cleaning_Service_Providers_ID PRIMARY KEY (ID);

-- -- Data seeding for the Table ----
-- Insert INto Cleaning_Service_Providers(Company_Name) VALUES('sahajCleanig')

--- Create table for celaning services type -- This is a cusotme datatype or in Entity framework can be the entity for class which is it selft user defined type 
--- like int user defined types are class or structure 

--
IF OBJECT_ID('dbo.Cleaning_Service_Type', 'U') IS NOT NULL 
  DROP TABLE dbo.Cleaning_Service_Type;
CREATE TABLE [Cleaning_Service_Type]
(
    [Id] UNIQUEIDENTIFIER NOT NULL,
    Service_Type_Name NVARCHAR(300)
)
ALTER TABLE Cleaning_Service_Type ADD CONSTRAINT PK_Cleaning_Service_type_ID PRIMARY KEY (ID);
ALTER TABLE [Cleaning_Service_Type] add  CONSTRAINT Cleaning_Service_Type_ID DEFAULT  NEWSEQUENTIALID () for ID;
ALTER TABLE [Cleaning_Service_Type] ADD CONSTRAINT UNIQUE_Cleaning_Service_Type_Name  UNIQUE (Service_Type_Name);

-- Cleaning workers type or cleaner type 
IF OBJECT_ID('dbo.Cleaning_Worker_Type', 'U') IS NOT NULL 
  DROP TABLE dbo.Cleaning_Worker_Type;
CREATE TABLE [Cleaning_Worker_Type]
(
    ID UNIQUEIDENTIFIER NOT NULL,
    Emploument_Type NVARCHAR(300)
)
ALTER TABLE Cleaning_Worker_Type ADD CONSTRAINT PK_Cleaning_worker_type_ID PRIMARY KEY (ID);
ALTER TABLE [Cleaning_Worker_Type] add  CONSTRAINT Cleaning_worker_Type_ID_Default DEFAULT  NEWSEQUENTIALID () for ID


