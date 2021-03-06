USE [AdventureWorks]
GO
/****** Object:  Table [Membership].[Profile]    Script Date: 09/24/2017 21:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Membership].[Profile](
	[ProfileID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Gender] [char](1) NOT NULL,
	[MaritalStatus] [int] NOT NULL,
	[HasChildren] [bit] NULL,
	[AddressLine1] [varchar](100) NOT NULL,
	[AddressLine2] [varchar](100) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](50) NOT NULL,
	[Country] [int] NOT NULL,
	[TimeZone] [nchar](10) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Profile_ProfileID] PRIMARY KEY CLUSTERED 
(
	[ProfileID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON
GO
ALTER TABLE [Membership].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_Profile_State] FOREIGN KEY([State])
REFERENCES [Demography].[State] ([StateCode])
GO
ALTER TABLE [Membership].[Profile] CHECK CONSTRAINT [FK_Profile_State]
GO
ALTER TABLE [Membership].[Profile]  WITH CHECK ADD  CONSTRAINT [FK_Profile_User] FOREIGN KEY([UserID])
REFERENCES [Membership].[User] ([UserID])
GO
ALTER TABLE [Membership].[Profile] CHECK CONSTRAINT [FK_Profile_User]