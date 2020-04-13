
-- Creating Database

CREATE DATABASE RIZOS_DB_SCHOOL;

USE RIZOS_DB_SCHOOL;

-- Creating Table Course
CREATE TABLE Course
(
 Course_ID int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
 Title     nvarchar(20) NOT NULL ,
 Stream    nvarchar(20) NOT NULL ,
 [Type]    nvarchar(20) NOT NULL ,
 StartDate date NOT NULL ,
 EndDate   date NOT NULL ,
 );

  -- Creating Table Assignment
  CREATE TABLE Assignment
(
 Assignment_ID int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
 Title         nvarchar(50) NOT NULL ,
 [Description] nvarchar(50) NOT NULL ,
 SubDateTime   date NOT NULL,
 OralMark      int ,
 TotalMark     int ,
 );

  -- Creating Table Student
  CREATE TABLE Student
(
 Student_ID    int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
 FirstName     nvarchar(20) NOT NULL ,
 LastName      nvarchar(20) NOT NULL ,
 DateOfBirth   date NOT NULL ,
 TuitionFees   decimal(6,2)  ,
 );

  -- Creating Table Trainer
 CREATE TABLE Trainer
(
 Trainer_ID int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
 FirstName  nvarchar(20) NOT NULL ,
 LastName   nvarchar(20) NOT NULL  ,
 [Subject]  nvarchar(20) NOT NULL ,
 );

  -- Creating Table SteudentPerCourse
  CREATE TABLE StudentPerCourse
(
 Course_ID  int NOT NULL ,
 Student_ID int NOT NULL ,
 CONSTRAINT PK_SPC PRIMARY KEY  (Course_ID,Student_ID),
 CONSTRAINT FK_Course_ID FOREIGN KEY (Course_ID)  REFERENCES [dbo].[Course]([Course_ID]),
 CONSTRAINT FK_Student_ID FOREIGN KEY (Student_ID)  REFERENCES [dbo].[Student]([Student_ID])
);

 -- Creating Table AssignmentPerCourse
CREATE TABLE AssignmentPerCourse
(
 Course_ID     int NOT NULL ,
 Assignment_ID int NOT NULL ,

 CONSTRAINT PK_APC PRIMARY KEY  (Assignment_ID,Course_ID),
 CONSTRAINT FK_Course_ID2 FOREIGN KEY (Course_ID)  REFERENCES [dbo].[Course]([Course_ID]),
 CONSTRAINT FK_Assignment_ID2 FOREIGN KEY (Assignment_ID)  REFERENCES [dbo].[Assignment]([Assignment_ID])

);

 -- Creating Table TrainerPerCourse
CREATE TABLE TrainerPerCourse
(
 Course_ID  int NOT NULL ,
 Trainer_ID int NOT NULL ,

 CONSTRAINT PK_TPC PRIMARY KEY  (Trainer_ID,Course_ID),
 CONSTRAINT FK_Course_ID3 FOREIGN KEY (Course_ID)  REFERENCES [dbo].[Course]([Course_ID]),
 CONSTRAINT FK_Trainer_ID2 FOREIGN KEY (Trainer_ID)  REFERENCES [dbo].[Trainer](Trainer_ID)

);