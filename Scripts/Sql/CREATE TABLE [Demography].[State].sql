USE [AdventureWorks]
GO
/****** Object:  Table [Demography].[State]    Script Date: 09/24/2017 21:37:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [Demography].[State](
	[StateCode] [char](2) NOT NULL,
	[Name] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK_State_StateCode] PRIMARY KEY CLUSTERED 
(
	[StateCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING ON