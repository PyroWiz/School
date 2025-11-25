/*
Use master
go
Drop Database Uni_Kita
go 
*/ 
    
CREATE DATABASE Uni_Kita
 COLLATE Hebrew_CI_AS
go

Use Uni_Kita
go 

-- יצירת טבלאות
Create Table Cities
(
City_code Int Not Null ,
City_Name Nvarchar(16)
)
GO

Create Table Students
(
Student_Id Int  NOT NUll,
Last_Name  Nvarchar(16) ,
First_Name Nvarchar(16) ,
City_Code Int ,
Birth_Date Date
)
GO

Create Table Courses
(
Course_Code Int NOT NULL,
Course_Name Nvarchar(16) ,
Nz Int
)
GO

Create Table Marks
(
Student_Id Int NOT NULL,
Course_Code Int NOT NULL,
Mark int
)
GO
