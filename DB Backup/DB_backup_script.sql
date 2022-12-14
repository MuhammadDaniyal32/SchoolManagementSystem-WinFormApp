
create database school_management_system
GO
USE [school_management_system]
GO
/****** Object:  Table [dbo].[attendence_details]    Script Date: 9/11/2019 10:19:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[attendence_details](
	[std_id] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[class] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[remarks] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[billing_details]    Script Date: 9/11/2019 10:19:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[billing_details](
	[std_id] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[class] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[tution_fees] [varchar](50) NULL,
	[other_charges] [varchar](50) NULL,
	[total_amount] [varchar](50) NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[enrollment_details]    Script Date: 9/11/2019 10:19:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[enrollment_details](
	[std_id] [varchar](50) NULL,
	[s_firstname] [varchar](50) NULL,
	[s_middlename] [varchar](50) NULL,
	[s_lastname] [varchar](50) NULL,
	[birthdate] [varchar](50) NULL,
	[age] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[birth_city] [varchar](50) NULL,
	[birth_province] [varchar](50) NULL,
	[birth_region] [varchar](50) NULL,
	[p_firstname] [varchar](50) NULL,
	[p_lastname] [varchar](50) NULL,
	[occupation] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[home_phone] [varchar](50) NULL,
	[cell_phone] [varchar](50) NULL,
	[std_class] [varchar](50) NULL,
	[tution_fees] [varchar](50) NULL,
	[other_charges] [varchar](50) NULL,
	[discount] [varchar](50) NULL,
	[total_amount] [varchar](50) NULL,
	[receipt_number] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[teachers_details]    Script Date: 9/11/2019 10:19:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teachers_details](
	[teacher_id] [varchar](50) NULL,
	[teacher_firstname] [varchar](50) NULL,
	[teacher_lastname] [varchar](50) NULL,
	[father_name] [varchar](50) NULL,
	[date_of_birth] [varchar](50) NULL,
	[age] [int] NULL,
	[qualification] [varchar](50) NULL,
	[subjects] [varchar](50) NULL,
	[salary] [varchar](50) NULL,
	[phone_no] [varchar](50) NULL,
	[classes_under] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_details]    Script Date: 9/11/2019 10:19:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user_details](
	[user_id] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[user_name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[type] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[billing_details] ([std_id], [firstname], [lastname], [class], [date], [tution_fees], [other_charges], [total_amount], [status]) VALUES (N'123456', N'Muhammad  ', N'Daniyal', N'Class Matric', N'10/September/2019', N'3,500', N'900', N'4,400', N'Paid')
INSERT [dbo].[billing_details] ([std_id], [firstname], [lastname], [class], [date], [tution_fees], [other_charges], [total_amount], [status]) VALUES (N'123457', N'Muhammad  ', N'Ali', N'Class 9', N'10/September/2019', N'3,500', N'900', N'4,400', N'Late Paid')
INSERT [dbo].[billing_details] ([std_id], [firstname], [lastname], [class], [date], [tution_fees], [other_charges], [total_amount], [status]) VALUES (N'213213', N'Muhammad  ', N'hassan', N'Class 2', N'11/September/2019', N'1,500', N'700', N'2,200', N'Late Paid')
INSERT [dbo].[billing_details] ([std_id], [firstname], [lastname], [class], [date], [tution_fees], [other_charges], [total_amount], [status]) VALUES (N'342345', N'Talha  ', N'Ali', N'Class 8', N'11/September/2019', N'3,000', N'800', N'3,800', N'UnPaid')
INSERT [dbo].[enrollment_details] ([std_id], [s_firstname], [s_middlename], [s_lastname], [birthdate], [age], [gender], [birth_city], [birth_province], [birth_region], [p_firstname], [p_lastname], [occupation], [address], [home_phone], [cell_phone], [std_class], [tution_fees], [other_charges], [discount], [total_amount], [receipt_number]) VALUES (N'123456', N'Muhammad', N'', N'Daniyal', N'Thursday, September 05, 2019', N'21', N'Male', N'karachi', N'sindh', N'north', N'Noor', N'hassan', N'shop', N'klfnvfnbvfbvlkfnknf', N'03332906880', N'0122323', N'Class Matric', N'3,500', N'900', N'', N'4,400', N'433545')
INSERT [dbo].[enrollment_details] ([std_id], [s_firstname], [s_middlename], [s_lastname], [birthdate], [age], [gender], [birth_city], [birth_province], [birth_region], [p_firstname], [p_lastname], [occupation], [address], [home_phone], [cell_phone], [std_class], [tution_fees], [other_charges], [discount], [total_amount], [receipt_number]) VALUES (N'123457', N'Muhammad', N'', N'Ali', N'Thursday, September 05, 2019', N'21', N'Male', N'karachi', N'sindh', N'north', N'Ahmed', N'hassan', N'shop', N'klfnvfnbvfbvlkfnknf', N'03332906880', N'0122323', N'Class 9', N'3,500', N'900', N'', N'4,400', N'45353')
INSERT [dbo].[enrollment_details] ([std_id], [s_firstname], [s_middlename], [s_lastname], [birthdate], [age], [gender], [birth_city], [birth_province], [birth_region], [p_firstname], [p_lastname], [occupation], [address], [home_phone], [cell_phone], [std_class], [tution_fees], [other_charges], [discount], [total_amount], [receipt_number]) VALUES (N'213213', N'Muhammad', N'', N'hassan', N'Monday, October 13, 2014', N'12', N'Male', N'karachi', N'sindh', N'', N'Ahmed', N'Ali', N'bussiness', N'xyz', N'01234456', N'01234456', N'Class 2', N'1,500', N'700', N'', N'2,200', N'23243')
INSERT [dbo].[enrollment_details] ([std_id], [s_firstname], [s_middlename], [s_lastname], [birthdate], [age], [gender], [birth_city], [birth_province], [birth_region], [p_firstname], [p_lastname], [occupation], [address], [home_phone], [cell_phone], [std_class], [tution_fees], [other_charges], [discount], [total_amount], [receipt_number]) VALUES (N'342345', N'Talha', N'', N'Ali', N'Thursday, June 01, 2000', N'19', N'Male', N'karachi', N'sindh', N'', N'Shabbir', N'Ali', N'bussiness', N'xyz', N'01234456', N'01234456', N'Class 8', N'3,000', N'800', N'', N'3,800', N'2343434')
INSERT [dbo].[teachers_details] ([teacher_id], [teacher_firstname], [teacher_lastname], [father_name], [date_of_birth], [age], [qualification], [subjects], [salary], [phone_no], [classes_under]) VALUES (N'3244', N'Majid', N'Ali', N'Ali Hassan', N'Tuesday, October 30, 1990', 25, N'B.scs', N'Computer science,P.s.t', N'25000', N'01234456', N'Matric classes')
INSERT [dbo].[user_details] ([user_id], [firstname], [lastname], [user_name], [password], [type]) VALUES (N'12332', N'Muhammad', N'Daniyal', N'DANIYAL', N'daniyal', N'Admin')
INSERT [dbo].[user_details] ([user_id], [firstname], [lastname], [user_name], [password], [type]) VALUES (N'32345', N'muhammad', N'ali', N'M.ALI', N'm.ali', N'Staff')
INSERT [dbo].[user_details] ([user_id], [firstname], [lastname], [user_name], [password], [type]) VALUES (N'22345', N'Arsalan', N'Astiq', N'ARSALAN', N'arsalan', N'Teacher')
