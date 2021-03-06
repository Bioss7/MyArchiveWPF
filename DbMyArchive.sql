USE [DbArchive]
GO
/****** Object:  Table [dbo].[AcademicLeave]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcademicLeave](
	[AcademicLeaveId] [int] IDENTITY(1,1) NOT NULL,
	[IdStudent] [int] NULL,
	[DateAcademicLeave] [datetime] NULL,
	[OrderNumber] [int] NULL,
	[DateExpiration] [datetime] NULL,
	[IdNumberGroup] [int] NULL,
 CONSTRAINT [PK_AcademicLeave] PRIMARY KEY CLUSTERED 
(
	[AcademicLeaveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diploma]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diploma](
	[DiplomaId] [int] IDENTITY(1,1) NOT NULL,
	[IdStudent] [int] NOT NULL,
	[Series] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[RegistrationNumber] [int] NOT NULL,
	[IdQualification] [int] NOT NULL,
	[IdSpecialty] [int] NOT NULL,
	[IdAcademicLeave] [int] NULL,
	[ApplicationSeries] [int] NOT NULL,
	[ApplicationNumber] [int] NOT NULL,
	[ApplicationDate] [datetime2](7) NOT NULL,
	[EnrollmentNumber] [int] NOT NULL,
	[EnrollmentDate] [datetime2](7) NOT NULL,
	[ReleaseNumber] [int] NOT NULL,
	[ReleaseDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Diploma] PRIMARY KEY CLUSTERED 
(
	[DiplomaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discipline]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discipline](
	[DisciplineId] [int] IDENTITY(1,1) NOT NULL,
	[IdStudent] [int] NOT NULL,
	[IdDisciplinesList] [int] NOT NULL,
	[NumberOfHours] [int] NOT NULL,
	[Rating] [int] NOT NULL,
 CONSTRAINT [PK_Discipline] PRIMARY KEY CLUSTERED 
(
	[DisciplineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisciplineList]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisciplineList](
	[DisciplineListId] [int] IDENTITY(1,1) NOT NULL,
	[DisciplineName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DisciplineList] PRIMARY KEY CLUSTERED 
(
	[DisciplineListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[IdPerson] [int] NOT NULL,
	[NumberReception] [int] NOT NULL,
	[DateReception] [datetime] NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
	[NumberFired] [int] NULL,
	[DateFired] [datetime] NULL,
	[СauseFired] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GroupStudentNumber]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupStudentNumber](
	[GroupStudentNumberId] [int] IDENTITY(1,1) NOT NULL,
	[NumberGroup] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_GroupStudentNumber] PRIMARY KEY CLUSTERED 
(
	[GroupStudentNumberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Middlename] [nvarchar](50) NULL,
	[DateofBirth] [datetime] NOT NULL,
	[IdPersonalDocument] [int] NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalDocument]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalDocument](
	[PersonalDocumentId] [int] IDENTITY(1,1) NOT NULL,
	[NumberPersonalDocument] [nvarchar](50) NOT NULL,
	[NumberInventory] [nvarchar](50) NOT NULL,
	[ShelfLife] [int] NOT NULL,
 CONSTRAINT [PK_PersonalDocument] PRIMARY KEY CLUSTERED 
(
	[PersonalDocumentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qualification]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qualification](
	[QualificationId] [int] IDENTITY(1,1) NOT NULL,
	[NameQualification] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Qualification] PRIMARY KEY CLUSTERED 
(
	[QualificationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialty](
	[SpecialtyId] [int] IDENTITY(1,1) NOT NULL,
	[SpecialtyName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Specialty] PRIMARY KEY CLUSTERED 
(
	[SpecialtyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 03.03.2020 11:11:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[IdPerson] [int] NOT NULL,
	[DateDeduction] [datetime2](7) NULL,
	[Reasonfordeduction] [nvarchar](50) NULL,
	[NumberGroup] [int] NULL,
	[EnrollmentNumber] [int] NULL,
	[EnrollmentDate] [datetime2](7) NULL,
	[DeductionNumber] [int] NULL,
	[DeductionDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AcademicLeave] ON 

INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1, 1, CAST(N'2020-02-15T00:00:00.000' AS DateTime), 777, CAST(N'2020-02-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (2, 1, CAST(N'2020-02-14T00:00:00.000' AS DateTime), 777, CAST(N'2020-02-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1002, 1, CAST(N'2020-02-20T00:00:00.000' AS DateTime), 321, CAST(N'2020-02-22T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1004, 1, CAST(N'2020-02-20T00:00:00.000' AS DateTime), 321, CAST(N'2020-02-22T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1005, 1, CAST(N'2020-02-20T00:00:00.000' AS DateTime), 321, CAST(N'2020-02-22T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1006, 1, CAST(N'2020-02-20T00:00:00.000' AS DateTime), 321, CAST(N'2020-02-22T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1007, 1, CAST(N'2020-03-01T00:00:00.000' AS DateTime), 123, CAST(N'2020-02-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1008, 1008, CAST(N'2020-02-21T00:00:00.000' AS DateTime), 213123, CAST(N'2020-02-15T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1009, 1, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3333, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (1010, 1, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3333, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (7003, 1005, CAST(N'2020-02-14T00:00:00.000' AS DateTime), 77777, CAST(N'2020-02-28T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[AcademicLeave] ([AcademicLeaveId], [IdStudent], [DateAcademicLeave], [OrderNumber], [DateExpiration], [IdNumberGroup]) VALUES (7004, 1005, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3333, CAST(N'2020-02-29T00:00:00.000' AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[AcademicLeave] OFF
SET IDENTITY_INSERT [dbo].[Diploma] ON 

INSERT [dbo].[Diploma] ([DiplomaId], [IdStudent], [Series], [Number], [RegistrationNumber], [IdQualification], [IdSpecialty], [IdAcademicLeave], [ApplicationSeries], [ApplicationNumber], [ApplicationDate], [EnrollmentNumber], [EnrollmentDate], [ReleaseNumber], [ReleaseDate]) VALUES (1004, 1007, 123, 123, 123, 1, 1, NULL, 123, 123, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 12321, CAST(N'2020-02-07T00:00:00.0000000' AS DateTime2), 12321, CAST(N'2020-02-19T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Diploma] ([DiplomaId], [IdStudent], [Series], [Number], [RegistrationNumber], [IdQualification], [IdSpecialty], [IdAcademicLeave], [ApplicationSeries], [ApplicationNumber], [ApplicationDate], [EnrollmentNumber], [EnrollmentDate], [ReleaseNumber], [ReleaseDate]) VALUES (1005, 1008, 777, 777, 777, 1, 1, NULL, 777, 777, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 777, CAST(N'2020-02-15T00:00:00.0000000' AS DateTime2), 777, CAST(N'2020-02-20T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Diploma] ([DiplomaId], [IdStudent], [Series], [Number], [RegistrationNumber], [IdQualification], [IdSpecialty], [IdAcademicLeave], [ApplicationSeries], [ApplicationNumber], [ApplicationDate], [EnrollmentNumber], [EnrollmentDate], [ReleaseNumber], [ReleaseDate]) VALUES (2002, 2009, 799, 6545, 725, 1, 1, NULL, 3241, 5456, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 274, CAST(N'2020-02-20T00:00:00.0000000' AS DateTime2), 855, CAST(N'2020-02-12T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Diploma] OFF
SET IDENTITY_INSERT [dbo].[Discipline] ON 

INSERT [dbo].[Discipline] ([DisciplineId], [IdStudent], [IdDisciplinesList], [NumberOfHours], [Rating]) VALUES (1, 1, 1, 25, 5)
SET IDENTITY_INSERT [dbo].[Discipline] OFF
SET IDENTITY_INSERT [dbo].[DisciplineList] ON 

INSERT [dbo].[DisciplineList] ([DisciplineListId], [DisciplineName]) VALUES (1, N'История')
INSERT [dbo].[DisciplineList] ([DisciplineListId], [DisciplineName]) VALUES (2, N'Русский-язык')
INSERT [dbo].[DisciplineList] ([DisciplineListId], [DisciplineName]) VALUES (3, N'Математика')
INSERT [dbo].[DisciplineList] ([DisciplineListId], [DisciplineName]) VALUES (4, N'Информатика')
SET IDENTITY_INSERT [dbo].[DisciplineList] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeId], [IdPerson], [NumberReception], [DateReception], [Position], [NumberFired], [DateFired], [СauseFired]) VALUES (1, 5012, 1, CAST(N'2020-02-13T00:00:00.000' AS DateTime), N'Сантехник', 1, CAST(N'2020-02-14T00:00:00.000' AS DateTime), N'Пошел вон отсюда пес')
INSERT [dbo].[Employee] ([EmployeeId], [IdPerson], [NumberReception], [DateReception], [Position], [NumberFired], [DateFired], [СauseFired]) VALUES (2, 11023, 123, CAST(N'2020-03-19T00:00:00.000' AS DateTime), N'повар', 123, CAST(N'2020-02-26T00:00:00.000' AS DateTime), N'поешл')
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[GroupStudentNumber] ON 

INSERT [dbo].[GroupStudentNumber] ([GroupStudentNumberId], [NumberGroup]) VALUES (1, N'671')
INSERT [dbo].[GroupStudentNumber] ([GroupStudentNumberId], [NumberGroup]) VALUES (2, N'672')
INSERT [dbo].[GroupStudentNumber] ([GroupStudentNumberId], [NumberGroup]) VALUES (3, N'673')
SET IDENTITY_INSERT [dbo].[GroupStudentNumber] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (1014, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (1015, N'Якимов', N'Владимир', N'Владимирович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2002, N'Ефимов', N'Кирилл', N'Сергеевич', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2003, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1003)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2004, N'Шумин', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2005, N'Шумин', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1005)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2006, N'Шумиха', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1006)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2007, N'Щухов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1007)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2008, N'Ивановов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1008)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2009, N'Иванововив', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1009)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2010, N'Иванович', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1010)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2011, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1011)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2012, N'Шумахер', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1012)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2013, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1013)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2014, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1014)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (2015, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 1015)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3011, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3012, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2003)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3013, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3014, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2005)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3015, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2006)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3016, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2007)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3017, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2008)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3018, N'Шухин', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2009)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3019, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2010)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3020, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2011)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3021, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2012)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3022, N'Ибрагим', N'Михаил', N'Юрьевич', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2013)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3023, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2014)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (3024, N'Абрамов', N'Дмитрий', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 2015)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (4011, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 3002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5011, N'Сергонко', N'Владимир', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5012, N'Абрагимов', N'Валентин', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4003)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5013, N'Арасян', N'Абрагим', N'Иванко', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5014, N'Абрагимов', N'Имбир', N'Орех', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4005)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5015, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4006)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5016, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4007)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (5017, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 4008)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (6015, N'Владимирович', N'Григорий', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 5002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (7015, N'Вадимович', N'Николай', N'Степаныч', CAST(N'2020-02-13T00:00:00.000' AS DateTime), 6002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (7016, N'Жымешкно', N'Игорь', N'Альбертович', CAST(N'2020-01-31T00:00:00.000' AS DateTime), 6003)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (8015, N'Жымешкно', N'Игорь', N'Альбертович', CAST(N'2020-01-31T00:00:00.000' AS DateTime), 7002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (8017, N'Дыменко', N'Дыменко', N'Дыменко', CAST(N'2020-02-13T00:00:00.000' AS DateTime), 7004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (9015, N'Иванов', N'Иван', N'Иванович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 8002)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (10017, N'Василий', N'Василий', N'Василий', CAST(N'2020-03-20T00:00:00.000' AS DateTime), 9004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (10018, N'Василий', N'Игорь', N'Василий', CAST(N'2020-03-20T00:00:00.000' AS DateTime), 9005)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11017, N'Ибрагимов', N'Михаил', N'Юрьевич', CAST(N'2020-03-06T00:00:00.000' AS DateTime), 10004)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11018, N'Борис', N'Ельцин', N'Игоривич', CAST(N'2020-03-14T00:00:00.000' AS DateTime), 10005)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11019, N'Борис', N'Ельцин', N'Игоривич', CAST(N'2020-03-14T00:00:00.000' AS DateTime), 10006)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11020, N'Борис', N'Ельцин', N'Игоривич', CAST(N'2020-03-14T00:00:00.000' AS DateTime), 10007)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11021, N'Борис', N'Ельцин', N'Игоривич', CAST(N'2020-03-14T00:00:00.000' AS DateTime), 10008)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11023, N'Иван', N'Борисович', N'Игоривич', CAST(N'2020-03-05T00:00:00.000' AS DateTime), 10010)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11024, N'Иван', N'Борисович', N'Игоривич', CAST(N'2020-03-05T00:00:00.000' AS DateTime), 10011)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (11025, N'Иван', N'Борисович', N'Игоривич', CAST(N'2020-03-05T00:00:00.000' AS DateTime), 10012)
INSERT [dbo].[Person] ([PersonId], [Lastname], [Firstname], [Middlename], [DateofBirth], [IdPersonalDocument]) VALUES (12015, N'Фиговый', N'Арган', N'Михайлович', CAST(N'1995-04-30T00:00:00.000' AS DateTime), 11002)
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[PersonalDocument] ON 

INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (3, N'2', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1002, N'2', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1003, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1004, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1005, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1006, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1007, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1008, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1009, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1010, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1011, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1012, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1013, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1014, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (1015, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2003, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2004, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2005, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2006, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2007, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2008, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2009, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2010, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2011, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2012, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2013, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2014, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (2015, N'1', N'2', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (3002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4002, N'1у', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4003, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4004, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4005, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4006, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4007, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (4008, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (5002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (6002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (6003, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (7002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (7003, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (7004, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (8002, N'1', N'1', 70)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (9002, N'123', N'123', 50)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (9003, N'1', N'1', 1)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (9004, N'1', N'1', 1)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (9005, N'1', N'1', 1)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10002, N'1', N'20', 23)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10003, N'1', N'1', 10)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10004, N'1', N'2', 30)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10005, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10006, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10007, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10008, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10009, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10010, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10011, N'11', N'11', 11)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10012, N'1', N'1', 20)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (10013, N'1', N'1', 10)
INSERT [dbo].[PersonalDocument] ([PersonalDocumentId], [NumberPersonalDocument], [NumberInventory], [ShelfLife]) VALUES (11002, N'1', N'12к', 70)
SET IDENTITY_INSERT [dbo].[PersonalDocument] OFF
SET IDENTITY_INSERT [dbo].[Qualification] ON 

INSERT [dbo].[Qualification] ([QualificationId], [NameQualification]) VALUES (1, N'профиссеональное')
SET IDENTITY_INSERT [dbo].[Qualification] OFF
SET IDENTITY_INSERT [dbo].[Specialty] ON 

INSERT [dbo].[Specialty] ([SpecialtyId], [SpecialtyName]) VALUES (1, N'Сетевое и системное администрирование')
INSERT [dbo].[Specialty] ([SpecialtyId], [SpecialtyName]) VALUES (2, N'Информационные системы и программирование')
INSERT [dbo].[Specialty] ([SpecialtyId], [SpecialtyName]) VALUES (3, N'Обеспечение информационной безопасности автоматизированных систем')
INSERT [dbo].[Specialty] ([SpecialtyId], [SpecialtyName]) VALUES (4, N'Монтажник радиоэлектронной аппаратуры и приборов.')
SET IDENTITY_INSERT [dbo].[Specialty] OFF
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1, 2012, NULL, NULL, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1005, 3021, NULL, NULL, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1006, 3022, NULL, NULL, 3, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1007, 3023, NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1008, 3024, NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (1011, 5017, NULL, N'Отчислен', 1, 123, CAST(N'2020-02-07T00:00:00.0000000' AS DateTime2), 123, CAST(N'2020-02-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (2009, 6015, NULL, NULL, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (5009, 9015, NULL, N'По собственному', 1, 321, CAST(N'2020-03-11T00:00:00.0000000' AS DateTime2), 123, CAST(N'2020-03-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Student] ([StudentId], [IdPerson], [DateDeduction], [Reasonfordeduction], [NumberGroup], [EnrollmentNumber], [EnrollmentDate], [DeductionNumber], [DeductionDate]) VALUES (7009, 12015, NULL, N'По собственному', 1, 467, CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), 123, CAST(N'2020-03-04T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Student] OFF
ALTER TABLE [dbo].[AcademicLeave]  WITH CHECK ADD  CONSTRAINT [FK_AcademicLeave_GroupStudentNumber] FOREIGN KEY([IdNumberGroup])
REFERENCES [dbo].[GroupStudentNumber] ([GroupStudentNumberId])
GO
ALTER TABLE [dbo].[AcademicLeave] CHECK CONSTRAINT [FK_AcademicLeave_GroupStudentNumber]
GO
ALTER TABLE [dbo].[AcademicLeave]  WITH CHECK ADD  CONSTRAINT [FK_AcademicLeave_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([StudentId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AcademicLeave] CHECK CONSTRAINT [FK_AcademicLeave_Student]
GO
ALTER TABLE [dbo].[Diploma]  WITH CHECK ADD  CONSTRAINT [FK_Diploma_AcademicLeave] FOREIGN KEY([IdAcademicLeave])
REFERENCES [dbo].[AcademicLeave] ([AcademicLeaveId])
GO
ALTER TABLE [dbo].[Diploma] CHECK CONSTRAINT [FK_Diploma_AcademicLeave]
GO
ALTER TABLE [dbo].[Diploma]  WITH CHECK ADD  CONSTRAINT [FK_Diploma_Qualification] FOREIGN KEY([IdQualification])
REFERENCES [dbo].[Qualification] ([QualificationId])
GO
ALTER TABLE [dbo].[Diploma] CHECK CONSTRAINT [FK_Diploma_Qualification]
GO
ALTER TABLE [dbo].[Diploma]  WITH CHECK ADD  CONSTRAINT [FK_Diploma_Specialty] FOREIGN KEY([IdSpecialty])
REFERENCES [dbo].[Specialty] ([SpecialtyId])
GO
ALTER TABLE [dbo].[Diploma] CHECK CONSTRAINT [FK_Diploma_Specialty]
GO
ALTER TABLE [dbo].[Diploma]  WITH CHECK ADD  CONSTRAINT [FK_Diploma_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([StudentId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Diploma] CHECK CONSTRAINT [FK_Diploma_Student]
GO
ALTER TABLE [dbo].[Discipline]  WITH CHECK ADD  CONSTRAINT [FK_Discipline_DisciplineList] FOREIGN KEY([IdDisciplinesList])
REFERENCES [dbo].[DisciplineList] ([DisciplineListId])
GO
ALTER TABLE [dbo].[Discipline] CHECK CONSTRAINT [FK_Discipline_DisciplineList]
GO
ALTER TABLE [dbo].[Discipline]  WITH CHECK ADD  CONSTRAINT [FK_Discipline_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[Discipline] CHECK CONSTRAINT [FK_Discipline_Student]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([IdPerson])
REFERENCES [dbo].[Person] ([PersonId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_PersonalDocument] FOREIGN KEY([IdPersonalDocument])
REFERENCES [dbo].[PersonalDocument] ([PersonalDocumentId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_PersonalDocument]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_GroupStudentNumber] FOREIGN KEY([NumberGroup])
REFERENCES [dbo].[GroupStudentNumber] ([GroupStudentNumberId])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_GroupStudentNumber]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Person] FOREIGN KEY([IdPerson])
REFERENCES [dbo].[Person] ([PersonId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Person]
GO
