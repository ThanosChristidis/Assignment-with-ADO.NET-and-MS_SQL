Create database CodingBootcamp_ADO;



create table Student(
	Student_ID int identity not null,
	FirstName varchar(50) not null, 
	LastName varchar(50) not null,
	DateOfBirth date null,
	Primary key (Student_ID));

create table Course(
	Course_ID int identity not null,
	Title varchar(30) not null,
	Stream varchar(10) not null,
	CType varchar(30) not null,
	StartDate date not null,
	EndDate   date not null,
	Primary key (Course_ID));

create table Trainer(
	Trainer_ID int identity not null,
	FirstName varchar(50) not null, 
	LastName varchar(50) not null,
	TSubject  varchar(50) not null,
	Primary key (Trainer_ID));

create table Project(
	Project_ID int identity not null,
	Title varchar(50) not null,
	Details varchar(255) null,
	SubmissionDate datetime not null,
	Primary key (Project_ID));

create table StudentPerCourse(
    Student_ID int not null,  
    Course_ID int not null,    
    constraint PK_SPC primary key (Student_ID, Course_ID),
    constraint FK_Student_ID foreign key (Student_ID) references [dbo].[Student]([Student_ID]),
    constraint FK_Course_ID foreign key (Course_ID) references [dbo].[Course]([Course_ID]));  

create table TrainerPerCourse(
    Trainer_ID int not null,
    Course_ID int not null,
    constraint PK_TPC primary key (Trainer_ID, Course_ID),
    constraint FK_Trainer_ID foreign key (Trainer_ID) references [dbo].[Trainer]([Trainer_ID]),
    constraint FK_Course_ID2 foreign key (Course_ID) references [dbo].[Course]([Course_ID]));

create table ProjectPerStudent(
    Project_ID int not null,
    Course_ID int not null,
    Student_ID int not null, 
    primary key (Project_ID, Course_ID, Student_ID),
    constraint FK_Project_ID foreign key (Project_ID) references [dbo].[Project]([Project_ID]),
    constraint FK_Course_ID3 foreign key (Course_ID) references [dbo].[Course]([Course_ID]),
    constraint FK_Student_ID2 foreign key (Student_ID) references [dbo].[Student]([Student_ID]));





USE [CodingBootcamp_ADO]
GO
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (1, 'Margarita', 'Anagnostou', CAST(N'2001-09-07' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (2, 'Stefanos', 'Gkikas', CAST(N'1991-02-10' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (3, 'Giorgos', 'Gkanos', CAST(N'1992-04-10' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (4, 'Thanos', 'Christidis', CAST(N'1990-04-22' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (5, 'Dimitra', 'Arsenopoulou', CAST(N'2000-05-25' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (6, 'Alexandra', 'Psila', CAST(N'1987-06-01' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (7, 'Eleni', 'Dimopoulou', CAST(N'1993-08-11' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (8, 'Marianna', 'Paparizou', CAST(N'1988-02-08' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (9, 'Andromachi', 'Pappasava', CAST(N'1994-09-26' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (10, 'Georgia', 'Zisi', CAST(N'1997-10-21' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (11, 'Melina', 'Fasilis', CAST(N'1995-09-20' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (12, 'Anastasia', 'Christidou', CAST(N'1988-12-28' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (13, 'Dionisis', 'Mantzaris', CAST(N'1994-11-13' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (14, 'Zacharias', 'Giannopoulos', CAST(N'1986-02-11' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (15, 'Alexandros', 'Papanikolaou', CAST(N'1998-05-22' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (16, 'Christos', 'Gotsis', CAST(N'2000-06-26' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (17, 'Katerina', 'Miltiadou', CAST(N'1999-11-11' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (18, 'Thanos', 'Foteinos', CAST(N'1973-03-07' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (19, 'Antonis', 'Toliadis', CAST(N'1996-03-08' AS Date))
INSERT [dbo].[Student] ([Student_ID], [FirstName], [LastName], [DateOfBirth]) VALUES (20, 'Aggeliki', 'Xenou', CAST(N'1995-06-18' AS Date))
SET IDENTITY_INSERT [dbo].[Student] OFF


USE [CodingBootcamp_ADO]
GO
SET IDENTITY_INSERT [dbo].[Course] ON

INSERT [dbo].[Course] ([Course_ID], [Title], [Stream], [CType], [StartDate], [EndDate]) VALUES (1, 'Java', 'CB9', 'Full Time', CAST(N'2020-01-01' AS Date), CAST(N'2020-03-30' AS Date))
INSERT [dbo].[Course] ([Course_ID], [Title], [Stream], [CType], [StartDate], [EndDate]) VALUES (2, 'Java', 'CB9', 'Part Time', CAST(N'2020-01-01' AS Date), CAST(N'2020-06-30' AS Date))
INSERT [dbo].[Course] ([Course_ID], [Title], [Stream], [CType], [StartDate], [EndDate]) VALUES (3, 'C#', 'CB9', 'Full Time', CAST(N'2020-01-01' AS Date), CAST(N'2020-03-30' AS Date))
INSERT [dbo].[Course] ([Course_ID], [Title], [Stream], [CType], [StartDate], [EndDate]) VALUES (4, 'C#', 'CB9', 'Part Time', CAST(N'2020-01-01' AS Date), CAST(N'2020-06-30' AS Date))
SET IDENTITY_INSERT [dbo].[Course] OFF






use [CodingBootcamp_ADO]
go
set identity_insert [dbo].[Project] on
insert [dbo].[Project] ([Project_ID], [Title], [Details], [SubmissionDate]) values (1, '"Calculator', null, CAST(N'2020-01-11' AS Date))
insert [dbo].[Project] ([Project_ID], [Title], [Details], [SubmissionDate]) values (2, 'Tic Tac Toe', null, CAST(N'2020-02-14' AS Date))
insert [dbo].[Project] ([Project_ID], [Title], [Details], [SubmissionDate]) values (3, 'Final Project', null, CAST(N'2020-04-16' AS Date))
insert [dbo].[Project] ([Project_ID], [Title], [Details], [SubmissionDate]) values (4, 'Fight Simulation', null, CAST(N'2020-03-24' AS Date))
insert [dbo].[Project] ([Project_ID], [Title], [Details], [SubmissionDate]) values (5, 'Credit Card Checker', null, CAST(N'2020-03-09' AS Date))

set identity_insert [dbo].[Project] off



use [CodingBootcamp_ADO]
go
set identity_insert [dbo].[Trainer] on

insert [dbo].[Trainer] ([Trainer_ID], [FirstName], [LastName], [TSubject]) values (1, 'George', 'Pasparakis', 'Back End Developer')
insert [dbo].[Trainer] ([Trainer_ID], [FirstName], [LastName], [TSubject]) values (2, 'Hector', 'Gatsos', 'Full Stack Developer')
insert [dbo].[Trainer] ([Trainer_ID], [FirstName], [LastName], [TSubject]) values (3, 'Kostas', 'Stroggulos', 'Database Developer')
insert [dbo].[Trainer] ([Trainer_ID], [FirstName], [LastName], [TSubject]) values (4, 'Katerina', 'Makrigianni', 'Web Developer')
insert [dbo].[Trainer] ([Trainer_ID], [FirstName], [LastName], [TSubject]) values (5, 'Georgia', 'Sotiropoulou', 'Back End Developer')
set identity_insert [dbo].[Trainer] off



insert into StudentPerCourse(Student_ID, Course_ID, TuitionFees) values 
(1,1, 2500.46),
(1,2,2100),
(2,3,2100),
(3,4,1500.62),
(3,3,1766),
(4,1,null),
(5,2,null),
(6,3,2200),
(7,2,null),
(8,4,1700.62),
(8,1,2200.60),
(9,4,1606),
(10,2,2500.47),
(11,2,1700.62),
(12,3,2741.85),
(13,3,null),
(14,4,1700.64),
(15,2,2400),
(16,1,1841),
(17,1,1744),
(18,2,2500),
(19,3,2323),
(20,4,2500);


INSERT INTO TrainerPerCourse (Trainer_ID,Course_ID)
VALUES (1,2), (1,1), (2,3),(3,4), (3,2), (4,1), (4,3), (5,2);


insert into ProjectPerStudent (Project_ID, Course_ID, Student_ID, OralMark, TotalMark) 
values (5,1,1,78,90),
(4,2,1,null,null),
(3,3,2,68,73),
(1,4,3,null, null),
(2,3,3,95,100),
(1,1,4,98, null),
(3,2,5,84,86),
(5,3,6,79, null),
(5,2,7,89, 85),
(4,4,8,78,83),
(2,1,8,95,97),
(1,4,9,68,74),
(5,2,10,67,null),
(2,2,11,null,null),
(2,3,12,null,null),
(5,3,13,74,79),
(1,4,14,88,92),
(3,2,15,100,100),
(3,1,16,null,null),
(4,1,17,68,66),
(5,2,18,63,80),
(4,3,19,91,90),
(2,4,20,null,null);
