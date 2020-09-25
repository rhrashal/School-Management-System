use SchoolManagementDB;
go
--01
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([Id], [Name], [CountryCode]) VALUES (1, N'Bangladesh', N'BD')
INSERT [dbo].[Country] ([Id], [Name], [CountryCode]) VALUES (2, N'America', N'US')
INSERT [dbo].[Country] ([Id], [Name], [CountryCode]) VALUES (3, N'India', N'IN')
SET IDENTITY_INSERT [dbo].[Country] OFF
go
--02
SET IDENTITY_INSERT [dbo].[Division] ON 

INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (1, N'Dhaka',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (2, N'Chittagang',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (3, N'Barisal',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (4, N'Sylhet',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (5, N'Rajshahi',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (6, N'Rangpur',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (7, N'Khulna',1)
INSERT [dbo].[Division] ([Id], [DivisionName],[CountryId]) VALUES (8, N'Mymensingh',1)
SET IDENTITY_INSERT [dbo].[Division] OFF
go
--03
SET IDENTITY_INSERT [dbo].[District] ON 

INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (1, N'Dhaka', 1)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (2, N'Brahmanbaria', 2)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (3, N'Bagherhat', 7)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (4, N'Bandarban', 2)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (5, N'Barguna', 3)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (6, N'Barishal', 3)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (7, N'Bhola', 3)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (8, N'Bogra', 5)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (9, N'C. Nawabganj', 5)
INSERT [dbo].[District] ([Id], [DistrictName], [DivisionId]) VALUES (10, N'Chandpur', 2)
SET IDENTITY_INSERT [dbo].[District] OFF

go
--04
SET IDENTITY_INSERT [dbo].[PoliceStation] ON 

INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (1, N'Dohar', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (2, N'Tejgaon Circle', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (3, N'Savar', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (4, N'Nawabganj', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (5, N'Keraniganj', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (6, N'Dhamrai', 1)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (7, N'Ashuganj', 2)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (8, N'Nasirnagar', 2)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (9, N'Sarail', 2)
INSERT [dbo].[PoliceStation] ([Id], [PoliceStationName], [DistrictId]) VALUES (10, N'Bancharampur', 2)
SET IDENTITY_INSERT [dbo].[PoliceStation] OFF

go
--05
SET IDENTITY_INSERT [dbo].[PostOffice] ON 

INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (1, N'Kushumhati', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (2, N'Mahmudpur', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (3, N'Moksedpur', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (4, N'Narisha', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (5, N'Nayabari', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (6, N'Raipara', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (7, N'Sutarpara', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (8, N'Bilashpur', 1)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (9, N'Sarulia', 2)
INSERT [dbo].[PostOffice] ([Id], [PostOfficeName], [PoliceStationId]) VALUES (10, N'Beraid', 2)
SET IDENTITY_INSERT [dbo].[PostOffice] OFF
go
--06
SET IDENTITY_INSERT [dbo].[Branch] ON 

INSERT [dbo].[Branch] ([Id], [BranchName], [Location], [Authority], [PostOfficeId]) VALUES (1, N'Mirpur', N'Mirpur', N'Jahid', 1)
INSERT [dbo].[Branch] ([Id], [BranchName], [Location], [Authority], [PostOfficeId]) VALUES (2, N'Cumilla', N'Cumilla', N'Jahangir', 2)
INSERT [dbo].[Branch] ([Id], [BranchName], [Location], [Authority], [PostOfficeId]) VALUES (3, N'Khilgaw', N'Dhaka', N'Khaled', 3)
INSERT [dbo].[Branch] ([Id], [BranchName], [Location], [Authority], [PostOfficeId]) VALUES (4, N'Keranigang', N'Sylet', N'Hamid', 4)
SET IDENTITY_INSERT [dbo].[Branch] OFF
go
--07
SET IDENTITY_INSERT [dbo].[SchoolVersion] ON 

INSERT [dbo].[SchoolVersion] ([Id], [SchoolVersionName]) VALUES (1, N'Bangla')
INSERT [dbo].[SchoolVersion] ([Id], [SchoolVersionName]) VALUES (2, N'English')
INSERT [dbo].[SchoolVersion] ([Id], [SchoolVersionName]) VALUES (3, N'Bangla & English')
SET IDENTITY_INSERT [dbo].[SchoolVersion] OFF

go
--08
SET IDENTITY_INSERT [dbo].[Quota] ON 

INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (1, N'General')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (2, N'Physically Challenged')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (3, N'BNCC')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (4, N'Tribal')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (5, N'Ansar-VDP')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (6, N'Orphan')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (7, N'Freedom Fighter')
INSERT [dbo].[Quota] ([Id], [QuotaName]) VALUES (8, N'Femail')
SET IDENTITY_INSERT [dbo].[Quota] OFF
go
--09
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity],[BranchId]) VALUES (1, N'101',60, 1)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (2, N'102',60, 1)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (3, N'103',60, 1)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (4, N'104', 60,1)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (5, N'201',60, 2)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (6, N'202',60, 2)
INSERT [dbo].[Room] ([Id], [RoomName], [SitCapacity], [BranchId]) VALUES (7, N'203',60, 2)
SET IDENTITY_INSERT [dbo].[Room] OFF
go
--10
SET IDENTITY_INSERT [dbo].[SchoolClass] ON 

INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (1, N'One')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (2, N'Two')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (3, N'Three')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (4, N'Four')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (5, N'Five')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (6, N'Six')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (7, N'Seven')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (8, N'Eight')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (9, N'Nine')
INSERT [dbo].[SchoolClass] ([Id], [ClassName]) VALUES (10, N'Ten')
SET IDENTITY_INSERT [dbo].[SchoolClass] OFF
go
--11
SET IDENTITY_INSERT [dbo].[Shift] ON 

INSERT [dbo].[Shift] ([Id], [ShiftName]) VALUES (1, N'Morning')
INSERT [dbo].[Shift] ([Id], [ShiftName]) VALUES (2, N'Day')
INSERT [dbo].[Shift] ([Id], [ShiftName]) VALUES (3, N'Evening')
SET IDENTITY_INSERT [dbo].[Shift] OFF
go

--13

SET IDENTITY_INSERT [dbo].[BranchClass] ON 

INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (2, 1, 2, 2, 1)
INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (3, 1, 3, 1, 2)
INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (4, 2, 1, 1, 2)
INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (5, 2, 2, 1, 3)
INSERT [dbo].[BranchClass] ([Id], [BranchId], [ShiftId], [SchoolVersionId], [SchoolClassId]) VALUES (6, 2, 3, 2, 3)
SET IDENTITY_INSERT [dbo].[BranchClass] OFF
GO
--14
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([Id], [GroupName]) VALUES (1, N'Business Studies')
INSERT [dbo].[Group] ([Id], [GroupName]) VALUES (2, N'Science')
INSERT [dbo].[Group] ([Id], [GroupName]) VALUES (3, N'Humainities')
SET IDENTITY_INSERT [dbo].[Group] OFF
go
--15
SET IDENTITY_INSERT [dbo].[Section] ON 

INSERT [dbo].[Section] ([Id], [SectionName], [GroupId], [BranchClassId]) VALUES (1, N'A', NULL, 1)
INSERT [dbo].[Section] ([Id], [SectionName], [GroupId], [BranchClassId]) VALUES (2, N'B', NULL, 2)
INSERT [dbo].[Section] ([Id], [SectionName], [GroupId], [BranchClassId]) VALUES (3, N'A', NULL, 2)
INSERT [dbo].[Section] ([Id], [SectionName], [GroupId], [BranchClassId]) VALUES (4, N'B', NULL, 3)
INSERT [dbo].[Section] ([Id], [SectionName], [GroupId], [BranchClassId]) VALUES (5, N'C', NULL, 3)
SET IDENTITY_INSERT [dbo].[Section] OFF
go
--16
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Id], [SubjectName], [SubjectCode], [SchoolClassId], [GroupId], [SchoolVersionId]) VALUES (1, N'Bangla', N'101', 1, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [SubjectName], [SubjectCode], [SchoolClassId], [GroupId], [SchoolVersionId]) VALUES (2, N'English', N'102', 1, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [SubjectName], [SubjectCode], [SchoolClassId], [GroupId], [SchoolVersionId]) VALUES (3, N'Math', N'103', 1, NULL, NULL)
INSERT [dbo].[Subject] ([Id], [SubjectName], [SubjectCode], [SchoolClassId], [GroupId], [SchoolVersionId]) VALUES (4, N'History', N'150', 2, 3, NULL)
INSERT [dbo].[Subject] ([Id], [SubjectName], [SubjectCode], [SchoolClassId], [GroupId], [SchoolVersionId]) VALUES (5, N'Higher Math', N'009', 3, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Subject] OFF
go
--17
SET IDENTITY_INSERT [dbo].[Designation] ON 

INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (1, N'Authority')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (2, N'Principal')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (3, N'Vice-Principal')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (4, N'Assistant Teacher')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (5, N'Jonior Teacher')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (6, N'Office Assistant')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (7, N'Office Support Stap')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (8, N'Libraryan')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (9, N'Gard')
INSERT [dbo].[Designation] ([Id], [DesignationName]) VALUES (10, N'Cleaner')
SET IDENTITY_INSERT [dbo].[Designation] OFF
GO
--18
SET IDENTITY_INSERT [dbo].[ApplicationForm] ON 


INSERT [dbo].[ApplicationForm] ([Id],[ApplicantId],[FirstName],[LastName],[DateOfBirth],[Gender],[Religion],[BirthRegistrationNo],[ImageUrl],[ApplingDate],[FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone],[MonthlyFamillyIncome],[FormarSchoolName],[IsSelected], [IsAdmitted], [PresentAddress],[ParmanentAddress],[PostOfficeId],[QuotaId],[BranchClassId])VALUES (1, 000001, N'Imran', N'Hossain', CAST(N'1996-06-10T00:00:00.0000000' AS DateTime2),  1, 1, N'258522647414', N'~/images/9.jpg', '2021-01-10',   N'Father', N'Govt', N'0123554254', N'mother', N'Houe Wife', N'013654185', 20000,  NULL, 0, 0, N'Dhaka', N'Dhaka',1, 1, 1)
INSERT [dbo].[ApplicationForm] ([Id],[ApplicantId],[FirstName],[LastName],[DateOfBirth],[Gender],[Religion],[BirthRegistrationNo],[ImageUrl],[ApplingDate],[FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone],[MonthlyFamillyIncome],[FormarSchoolName],[IsSelected], [IsAdmitted], [PresentAddress],[ParmanentAddress],[PostOfficeId],[QuotaId],[BranchClassId]) VALUES (2, 000002, N'Saleha', N'Akter', CAST(N'1997-02-04T00:00:00.0000000' AS DateTime2),  2, 1, N'01245632365',  N'~/images/10.jpg', '2021-01-10',  N'father', N'private', N'0185463126', N'mother', N'Banker', N'019654841', 30000, N'old School',1, 0, N'Comilla', N'Dhaka',  1,  2, 2)
SET IDENTITY_INSERT [dbo].[ApplicationForm] OFF
go
--19
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([Id], [FirstName], [LastName], [DateOfBirth], [Gender], [Religion], [PhoneNo], [Email], [NationalIdNo], [ImageUrl], [CreatedDate], [FathersName], [MothersName], [MaritalStatus], [IsPresent], [JoiningDate], [ResignDate], [PresentAddress], [ParmanentAddress],  [FingerData], [PostOfficeId], [BranchId], [DesignationId]) VALUES (1, N'Sharmin', N'Akter', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2),  1, 0, N'01854658124', N'sharmi@gmaill.com', N'4652341564', N'~/imgae/01.jpg', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), N'father', N'mothers', 0, 1, CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, N'dahaka', N'barisal', NULL, 1, 1, 2)
INSERT [dbo].[Staff] ([Id], [FirstName], [LastName], [DateOfBirth], [Gender], [Religion], [PhoneNo], [Email], [NationalIdNo], [ImageUrl], [CreatedDate], [FathersName], [MothersName], [MaritalStatus], [IsPresent], [JoiningDate], [ResignDate], [PresentAddress], [ParmanentAddress],  [FingerData], [PostOfficeId], [BranchId], [DesignationId]) VALUES (2, N'Rokiya', N'Akter', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2),  1, 0, N'01254521455', N'rokiya@gmail.com', N'6542315841', N'~/images/03.jpg', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2), N'fatjer', N'mothre', 0, 1, CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, N'MEGHNA', N'cumilla', NULL, 2, 1, 2)
SET IDENTITY_INSERT [dbo].[Staff] OFF
go
--20


-- SET IDENTITY_INSERT [dbo].[Student] ON 

-- INSERT [dbo].[Student] ([Id], [StudentIdNo],  [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [Gender], [Religion], [BirthRegistrationNo], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName],  [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [FingerData], [PresentAddress], [ParmanentAddress], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (1, N'10000001', 101010, N'Robiul', N'Hossain', N'aaaaaaa', CAST(N'2000-10-04T00:00:00.0000000' AS DateTime2), 0, 0, N'4514215423166', N'~/images/07.jpg', N'Abdul', N'Private Employee', N'01854625441', N'Rehana', N'HouseWife', N'0164250154', 20000, NULL,  N'Abdul', N'0185451445', N'girtian@gmail.com', N'father', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, N'Dhaka', N'Cumilla', 1, 1, NULL, 1)
-- INSERT [dbo].[Student] ([Id], [StudentIdNo],  [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [Gender], [Religion], [BirthRegistrationNo], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName],  [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [FingerData], [PresentAddress], [ParmanentAddress], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (2, N'10000002', 101210, N'kawser', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), 0, 0, N'4654354165442', N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL',  N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, N'cumilla', N'Noakhali', 2, NULL, 1, 1)
-- SET IDENTITY_INSERT [dbo].[Student] OFF


go
--21
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([Id], [FirstName], [LastName], [DateOfBirth], [Gender], [Religion], [PhoneNo], [Email], [NationalIdNo], [FingerData], [IsPresent], [ImageUrl], [CreatedDate], [MaritalStatus], [FathersName], [MothersName], [JoiningDate], [ResignDate], [BranchId], [DesignationId], [SubjectId], [PostOfficeId]) VALUES (1, N'Teacher1', N'Techar4', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2), 0, 0, N'0183215245641', N'teavcharft@gmail.com', N'64521654545', NULL, 1, N'!/images/01.jpg', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), 1, N'father', N'motheer', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, 1, 1, 1)
INSERT [dbo].[Teacher] ([Id], [FirstName], [LastName], [DateOfBirth], [Gender], [Religion], [PhoneNo], [Email], [NationalIdNo], [FingerData], [IsPresent], [ImageUrl], [CreatedDate], [MaritalStatus], [FathersName], [MothersName], [JoiningDate], [ResignDate], [BranchId], [DesignationId], [SubjectId], [PostOfficeId]) VALUES (2, N'taechart2', N'kagert', CAST(N'2000-01-01T00:00:00.0000000' AS DateTime2), 1, 1, N'0186341251241', N'sdakj;fj@gmail.colm', N'4465456453', NULL, 0, N'~/IMGAE/01.JPG', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), 1, N'FATJEH', N'M,AOJTGLKS', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
--22
SET IDENTITY_INSERT [dbo].[ClassRoom] ON 

INSERT [dbo].[ClassRoom] ([Id], [BranchClassId], [RoomId], [SectionId], [TeacherId]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[ClassRoom] ([Id], [BranchClassId], [RoomId], [SectionId], [TeacherId]) VALUES (2, 1, 2, 1, 2)
INSERT [dbo].[ClassRoom] ([Id], [BranchClassId], [RoomId], [SectionId], [TeacherId]) VALUES (3, 2, 3, 2, 1)
INSERT [dbo].[ClassRoom] ([Id], [BranchClassId], [RoomId], [SectionId], [TeacherId]) VALUES (4, 3, 2, 4, 2)
INSERT [dbo].[ClassRoom] ([Id], [BranchClassId], [RoomId], [SectionId], [TeacherId]) VALUES (5, 6, 5, 3, 1)
SET IDENTITY_INSERT [dbo].[ClassRoom] OFF
GO
--23
SET IDENTITY_INSERT [dbo].[ClassRoutine] ON 

INSERT [dbo].[ClassRoutine] ([Id], [StartTime], [EndTime], [ClassDuration], [PeriodNumber], [SubjectId], [TeacherId], [ClassRoomId], [DayOfWeek]) VALUES (1, CAST(N'08:00:00' AS Time), CAST(N'08:40:00' AS Time), N'40', 1, 1, 1, 1, 3)
INSERT [dbo].[ClassRoutine] ([Id], [StartTime], [EndTime], [ClassDuration], [PeriodNumber], [SubjectId], [TeacherId], [ClassRoomId], [DayOfWeek]) VALUES (2, CAST(N'08:40:00' AS Time), CAST(N'09:20:00' AS Time), N'40', 2, 2, 2, 2, 3)
SET IDENTITY_INSERT [dbo].[ClassRoutine] OFF
go
--24
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([Id], [ExamType], [ExamDiscription], [StartDate], [EndDate], [Duration], [PassingRate], [IsActive], [BranchId]) VALUES (1, N'Half Yearly', N'this is 50 mark & class under 8 ', CAST(N'2020-09-10T00:00:00.0000000' AS DateTime2), CAST(N'2020-10-30T00:00:00.0000000' AS DateTime2), N'3 Hour', 50, 1, 1)
INSERT [dbo].[Exam] ([Id], [ExamType], [ExamDiscription], [StartDate], [EndDate], [Duration], [PassingRate], [IsActive], [BranchId]) VALUES (2, N'Yearly', N'100 marks', CAST(N'2020-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2), N'3 Hour',  40, 1, 1)
SET IDENTITY_INSERT [dbo].[Exam] OFF
go
--25
-- SET IDENTITY_INSERT [dbo].[ExamRoutine] ON 

-- INSERT [dbo].[ExamRoutine] ([Id], [ExamDate], [TotalNumber],  [SchoolClassId], [ExamId], [ShiftId], [SubjectId]) VALUES (1, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 100,  1, 1, 2, 1)
-- INSERT [dbo].[ExamRoutine] ([Id], [ExamDate], [TotalNumber],  [SchoolClassId], [ExamId], [ShiftId], [SubjectId]) VALUES (2, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 50,  2, 1, 2, 2)
-- SET IDENTITY_INSERT [dbo].[ExamRoutine] OFF
go
--26
-- SET IDENTITY_INSERT [dbo].[ExamResult] ON 

-- INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [GradePoint], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (1,  CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 100, 95, 1, 5.00, 95, 1, 1,  N'Study More', 1, 1, 1)
-- INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [GradePoint], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (2,  CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 100, 95, 1, 5.00, 95, 2, 1,  N'rest new',   1, 1, 2 )
-- SET IDENTITY_INSERT [dbo].[ExamResult] OFF
-- go
--27
-- SET IDENTITY_INSERT [dbo].[ExamMark] ON 

-- INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [GradePoint], [HighestMark], [Position], [ExamId], [ExamRoutineId], [SubjectId], [StudentId]) VALUES (1, 75, 1, 4.5, 75, 1, 1, 1, 1, 2)
-- INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [GradePoint], [HighestMark], [Position], [ExamId], [ExamRoutineId], [SubjectId], [StudentId]) VALUES (2, 63, 1, 3.5, 75, 1, 1, 2, 2, 1)
-- INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [GradePoint], [HighestMark], [Position], [ExamId], [ExamRoutineId], [SubjectId], [StudentId]) VALUES (3, 38, 1, 4.0, 38, 1, 1, 2, 3, 2)
-- SET IDENTITY_INSERT [dbo].[ExamMark] OFF

go
--28
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([Id], [EventName], [StartDate], [EndDate], [EventControlar], [Venue], [ImageUrl], [BranchId]) VALUES (1, N'Orentation', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'Khalid', N'Morgipara',  N'~/images/11.jpg', 1)
INSERT [dbo].[Event] ([Id], [EventName], [StartDate], [EndDate], [EventControlar], [Venue], [ImageUrl], [BranchId]) VALUES (2, N'Farewell', CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2), CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2), N'Jahangir', N'Mawa', N'~/images/12.jpg', 1)
SET IDENTITY_INSERT [dbo].[Event] OFF

go
--29

SET IDENTITY_INSERT [dbo].[Holiday] ON 

INSERT [dbo].[Holiday] ([Id], [HolidayName], [StartDate], [EndDate], [NumberOfDay]) VALUES (1, N'Summer Session', CAST(N'2021-02-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-02-10T00:00:00.0000000' AS DateTime2), 10)
INSERT [dbo].[Holiday] ([Id], [HolidayName], [StartDate], [EndDate], [NumberOfDay]) VALUES (2, N'Eid Ul Azha', CAST(N'2020-06-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-06-06T00:00:00.0000000' AS DateTime2), 6)
SET IDENTITY_INSERT [dbo].[Holiday] OFF

go
--30
SET IDENTITY_INSERT [dbo].[RulesRegulation] ON 

INSERT [dbo].[RulesRegulation] ([Id], [RuleDetails], [BranchId]) VALUES (1, N'Must be use Unifrom. Attend Correct Time', 1)
INSERT [dbo].[RulesRegulation] ([Id], [RuleDetails], [BranchId]) VALUES (2, N'Must be use Unifrom. Attend Correct Time', 2)
SET IDENTITY_INSERT [dbo].[RulesRegulation] OFF

go
--31
go
SET IDENTITY_INSERT [dbo].[NoticeBoard] ON 

INSERT [dbo].[NoticeBoard] ([Id], [TopicName], [NoticeBody], [PublishDate], [BranchId]) VALUES (1, N'Exam', N'2nd september will held montly Exam', CAST(N'2020-08-31T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[NoticeBoard] ([Id], [TopicName], [NoticeBody], [PublishDate], [BranchId]) VALUES (2, N'Result', N'Final Result', CAST(N'2020-12-31T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[NoticeBoard] OFF


go

SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (1, N'10000001', 101010, N'Robiul', N'Hossain', N'aaaaaaa', CAST(N'2000-10-04T00:00:00.0000000' AS DateTime2), N'4514215423166', 0, 0, NULL, N'~/images/07.jpg', N'Abdul', N'Private Employee', N'01854625441', N'Rehana', N'HouseWife', N'0164250154', 20000, NULL, N'Abdul', N'0185451445', N'girtian@gmail.com', N'father', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'Dhaka', N'Cumilla', NULL, 1, 1, 1, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (2, N'10000002', 101211, N'kawser1', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 1, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (3, N'10000003', 101212, N'kawser2', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 1, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (4, N'10000004', 101213, N'kawser3', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 1, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (5, N'10000005', 101214, N'kawser4', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 1, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (6, N'10000006', 101215, N'kawser5', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 2, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (7, N'10000007', 101216, N'kawser6', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 2, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (8, N'10000008', 101217, N'kawser7', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 2, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (9, N'10000009', 101218, N'kawser8', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 2, 1)
INSERT [dbo].[Student] ([Id], [StudentIdNo], [RollNo], [FirstName], [LastName], [FullName], [DateOfBirth], [BirthRegistrationNo], [Gender], [Religion], [BloodGroup], [ImageUrl], [FatherName], [FatherOccupation], [FatherPhone], [MotherName], [MotherOccupation], [MotherPhone], [MonthlyFamillyIncome], [FormarSchoolName], [GuardianName], [GuardianPhoneNo], [GuardianEmail], [RelationOfAltGuardian], [AdmissionDate], [PresentAddress], [ParmanentAddress], [FingerData], [PostOfficeId], [QuotaId], [SectionId], [BranchClassId]) VALUES (10, N'10000010', 101219, N'kawser9', N'Hossain', N'bbbbbbbbb', CAST(N'2000-10-05T00:00:00.0000000' AS DateTime2), N'4654354165442', 0, 0, NULL, N'~/images/08.jpg', N'abul', N'gvt', N'01825434561', N'sultana', N'private', N'0185542544', 30000, N'OLD SCHOOL', N'SULTAN', N'01698525441', N'sulata@gmail.com', N'mother', CAST(N'2021-01-01T00:00:00.0000000' AS DateTime2), N'cumilla', N'Noakhali', NULL, 2, NULL, 2, 1)
SET IDENTITY_INSERT [dbo].[Student] OFF

GO 
SET IDENTITY_INSERT [dbo].[ExamRoutine] ON 

INSERT [dbo].[ExamRoutine] ([Id], [ExamDate], [TotalNumber], [SchoolClassId], [ExamId], [ShiftId], [SubjectId]) VALUES (1, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 100, 1, 1, 1, 1)
INSERT [dbo].[ExamRoutine] ([Id], [ExamDate], [TotalNumber], [SchoolClassId], [ExamId], [ShiftId], [SubjectId]) VALUES (2, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 100, 1, 1, 1, 2)
INSERT [dbo].[ExamRoutine] ([Id], [ExamDate], [TotalNumber], [SchoolClassId], [ExamId], [ShiftId], [SubjectId]) VALUES (3, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 100, 1, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[ExamRoutine] OFF
GO

go
SET IDENTITY_INSERT [dbo].[AttendanceOfStudent] ON 

INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (1, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (2, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (3, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (4, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (5, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 5)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (6, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 6)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (7, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 7)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (8, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 8)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (9, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 9)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (10, CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-03T00:00:00.0000000' AS DateTime2), 10)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (11, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (12, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (13, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (14, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (15, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 5)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (16, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 6)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (17, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 7)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (18, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 8)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (19, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 9)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (20, CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-04T00:00:00.0000000' AS DateTime2), 10)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (21, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (22, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (23, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 3)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (24, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 4)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (25, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 5)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (26, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 6)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (27, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 7)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (28, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 8)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (29, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 9)
INSERT [dbo].[AttendanceOfStudent] ([Id], [AttendTime], [LeaveTime], [StudentId]) VALUES (30, CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), CAST(N'2020-09-05T00:00:00.0000000' AS DateTime2), 10)
SET IDENTITY_INSERT [dbo].[AttendanceOfStudent] OFF
go

GO
SET IDENTITY_INSERT [dbo].[ExamResultPoint] ON 

INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (1, 100, 80, 5, N'A+', N'Congratulation! Your Result is very Good.', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (2, 79, 70, 4, N'A', N'Your Result is Good. For Continue class your gardian Should be Communicate with school Authority.', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (3, 69, 60, 3.5, N'A-', N'Your Result is Not better. For Continue class your gardian Should be Communicate with school Authority', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (4, 59, 50, 3, N'B', N'Your Result is Not good. For Continue class your gardian Should be Communicate with school Authority.', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (5, 49, 40, 2, N'C', N'Your Result is bed. For Continue class your gardian Should be Communicate with school Authority', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (6, 39, 33, 1, N'D', N'Your Result is very bed. For Continue class your gardian must be Communicate with school Authority.', 1)
INSERT [dbo].[ExamResultPoint] ([Id], [MaximumMark], [MinimumMark], [Point], [Grade], [Note], [BranchId]) VALUES (7, 32, 0, 0, N'F', N'Your Result is very bed. For Continue class your gardian must be Communicate with school Authority.', 1)
SET IDENTITY_INSERT [dbo].[ExamResultPoint] OFF

GO


SET IDENTITY_INSERT [dbo].[ExamMark] ON 

INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (1, 62, 1, 3.5, N'A-', 86, 3, 1, 1, 1)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (2, 86, 1, 5, N'A+', 86, 1, 1, 1, 2)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (3, 75, 1, 4, N'A', 86, 2, 1, 1, 3)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (4, 59, 1, 3, N'B', 86, 4, 1, 1, 4)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (5, 38, 0, 0, N'F', 86, 5, 1, 1, 5)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (6, 75, 1, 4, N'A', 92, 3, 1, 1, 6)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (7, 81, 1, 5, N'A+', 92, 2, 1, 1, 7)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (8, 92, 1, 5, N'A+', 92, 1, 1, 1, 8)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (9, 45, 0, 0, N'F', 92, 5, 1, 1, 9)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (10, 68, 1, 3.5, N'A-', 92, 4, 1, 1, 10)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (11, 55, 1, 3, N'B', 77, 5, 1, 2, 1)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (12, 76, 1, 4, N'A', 77, 2, 1, 2, 2)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (13, 62, 1, 3.5, N'A-', 77, 4, 1, 2, 3)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (14, 77, 1, 4, N'A', 77, 1, 1, 2, 4)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (15, 68, 1, 3.5, N'A-', 77, 3, 1, 2, 5)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (16, 72, 1, 4, N'A-', 87, 2, 1, 2, 6)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (17, 87, 1, 5, N'A-', 87, 1, 1, 2, 7)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (18, 58, 1, 3, N'A-', 87, 4, 1, 2, 8)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (19, 52, 1, 3, N'A-', 87, 5, 1, 2, 9)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (20, 69, 1, 3.5, N'A-', 87, 3, 1, 2, 10)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (21, 70, 1, 4, N'A-', 75, 3, 1, 3, 1)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (22, 70, 1, 4, N'A-', 75, 2, 1, 3, 2)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (23, 65, 1, 3.5, N'A-', 75, 4, 1, 3, 3)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (24, 45, 0, 0, N'A-', 75, 5, 1, 3, 4)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (25, 75, 1, 4, N'A-', 75, 1, 1, 3, 5)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (26, 69, 1, 3.5, N'A-', 96, 5, 1, 3, 6)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (27, 78, 1, 4, N'A-', 96, 4, 1, 3, 7)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (28, 96, 1, 5, N'A-', 96, 1, 1, 3, 8)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (29, 78, 1, 4, N'A-', 96, 3, 1, 3, 9)
INSERT [dbo].[ExamMark] ([Id], [ObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [ExamId], [ExamRoutineId], [StudentId]) VALUES (30, 78, 1, 4, N'A-', 96, 2, 1, 3, 10)
SET IDENTITY_INSERT [dbo].[ExamMark] OFF
go
SET IDENTITY_INSERT [dbo].[ExamResult] ON 

INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (1, CAST(N'2020-09-20T20:18:48.9763319' AS DateTime2), 300, 187, 1, 3.5, N'A-', 232, 3, 3, N'Your Result is Not better. For Continue class your gardian Should be Communicate with school Authority.', 1, 1, 1)
INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (2, CAST(N'2020-09-20T20:18:49.3234515' AS DateTime2), 300, 232, 1, 4.33, N'A', 232, 1, 3, N'Your Result is Good. For Continue class your gardian Should be Communicate with school Authority.', 1, 1, 2)
INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (3, CAST(N'2020-09-20T20:18:49.3300370' AS DateTime2), 300, 202, 1, 3.67, N'A-', 232, 2, 3, N'Your Result is Not better. For Continue class your gardian Should be Communicate with school Authority.', 1, 1, 3)
INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (4, CAST(N'2020-09-20T20:18:49.3359786' AS DateTime2), 300, 181, 0, 0, N'F', 232, 5, 3, N'Your Result is very bed. For Continue class your gardian must be Communicate with school Authority.', 1, 1, 4)
INSERT [dbo].[ExamResult] ([Id], [ResultPublishDate], [TotalMark], [TotalObtainMark], [ResultStatus], [Point], [Grade], [HighestMark], [Position], [TotalPresent], [Note], [ExamId], [SectionId], [StudentId]) VALUES (5, CAST(N'2020-09-20T20:18:49.3455754' AS DateTime2), 300, 181, 0, 0, N'F', 232, 4, 3, N'Your Result is very bed. For Continue class your gardian must be Communicate with school Authority.', 1, 1, 5)
SET IDENTITY_INSERT [dbo].[ExamResult] OFF
