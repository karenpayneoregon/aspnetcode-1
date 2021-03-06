/*
	Instructions

	1. Open SSMS (SQL-Server Management Studio)
	2. Create a new database named EmployeeDB
	3. From Object Explorer, select "Databases"
	4. Right click on "Databases", select "Refresh"
	5. Create a new query using the "New Query" button
	6. Copy the script below into the new query
	7. Press F5 to generate the able "Employees"
		7A. If there are issues, notify Karen
	8. Select the "Tables" node from  Object Explorer and right click, select refesh
	9. Right click on the table "Employees" -> Select top 1000 to verify records exists
*/


USE [EmployeeDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/6/2021 10:28:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 7/6/2021 10:28:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NOT NULL,
	[EmpCode] [varchar](10) NULL,
	[Position] [varchar](100) NULL,
	[OfficeLocation] [varchar](100) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20181223091420_InitialCreate', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FullName], [EmpCode], [Position], [OfficeLocation]) VALUES (1, N'Karen Payne', N'100', N'Developer', N'Salem Oregon')
INSERT [dbo].[Employees] ([EmployeeId], [FullName], [EmpCode], [Position], [OfficeLocation]) VALUES (2, N'Yelena Galante', N'200', N'Developer', N'Salem Oregon')
INSERT [dbo].[Employees] ([EmployeeId], [FullName], [EmpCode], [Position], [OfficeLocation]) VALUES (3, N'Lisa Smith-Burham', N'300', N'Developer', N'Salem Oregon')
INSERT [dbo].[Employees] ([EmployeeId], [FullName], [EmpCode], [Position], [OfficeLocation]) VALUES (4, N'Fred Winger', N'400', N'Developer', N'Salem Oregon')
INSERT [dbo].[Employees] ([EmployeeId], [FullName], [EmpCode], [Position], [OfficeLocation]) VALUES (5, N'Bill Rickman', N'500', N'Developer', N'Salem Oregon')
SET IDENTITY_INSERT [dbo].[Employees] OFF
USE [master]
GO
ALTER DATABASE [EmployeeDB] SET  READ_WRITE 
GO
