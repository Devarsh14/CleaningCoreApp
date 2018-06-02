-- cleaning services can be provides by cleaning company as type -- like 

use CleaningSoftwareLogic
INSERT into Cleaning_Service_Type (Service_Type_Name) VALUES ('House Cleaning'),
('Commercial Cleaning'),
('Industrial Cleaning'),
('Office Cleaning'),
('School Cleaning'),
('Bond Cleaning')


--SELECT * from Cleaning_Service_Type
Insert INTO Cleaning_Worker_Type(Emploument_Type) values ('Permanent')
,('Casual')
,('Contractor')
,('Agency Hire')
,('SunContractor')


-- Inserting multiple values into tabel Cleaning service provider 
insert Into Cleaning_Service_Providers ([Company_Name])
SELECT 'JJSmith' 
UNION ALL 
SELECT 'DCS Organisation ltd'
UNION ALL 
SELECT 'RIPAL Shukla org ltd'




INSERT into cleaner_detail([cleaner_detail_name])  values ('Devarsh')

INSERT into cleaner_detail([cleaner_detail_name])  values ('Demitry')
INSERT into cleaner_detail([cleaner_detail_name])  values ('Rosesh')
INSERT into cleaner_detail([cleaner_detail_name])  values ('Jalpa')
INSERT into cleaner_detail([cleaner_detail_name])  values ('Jaymin')