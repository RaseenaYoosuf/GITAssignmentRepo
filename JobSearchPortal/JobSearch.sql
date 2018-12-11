USE [master]
GO

DROP TABLE [dbo].[JobOpening]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[JobOpening](
	[JobId] [varchar](40) NOT NULL,
	[JobName] [varchar](40) NOT NULL,
	[KeySkills] [varchar](100) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Experience] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

SET ANSI_PADDING OFF
GO

Insert into JobOpening values('JOBJAVA01','Developer', 'Java', 'Developer with handson experience in JAVA, JQuery', '2 to 3 Years')
Insert into JobOpening values('JOBJAVA02','Senior Developer', 'Java', 'Sr.Developer with handson experience in JAVA, JQuery, Java Script, AngularJS', '5 to 8 Years')
Insert into JobOpening values('JOBNET01','Developer', 'Dot Net', 'Developer with handson experience in C#, SQL, MVC, WCF', '2 to 3 Years')
Insert into JobOpening values('JOBNET02','Senior Developer', 'Dot Net', 'Sr.Developer with handson experience in C#, SQL, MVC, WCF, TFS', '5 to 8 Years')
Insert into JobOpening values('JOBMSBI01','Developer', 'MSBI', 'Developer with handson experience in SSIS, SSRS', '2 to 3 Years')
Insert into JobOpening values('JOBMSBI02','Senior Developer', 'MSBI', 'Sr.Developer with handson experience in SSIS, SSRS, Power BI, SSAS, SQL', '5 to 8 Years')


select * from JobOpening