USE [AdventureWorks]
GO

/****** Object:  Table [Membership].[UserPreference]    Script Date: 04/10/2017 16:57:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Membership].[UserPreference](
	[UserPreferenceID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[LikesBlack] [bit] NULL,
	[LikesBlue] [bit] NULL,
	[LikesGrey] [bit] NULL,
	[LikesMulti] [bit] NULL,
	[LikesRed] [bit] NULL,
	[LikesSilver] [bit] NULL,
	[LikesWhite] [bit] NULL,
	[LikesYellow] [bit] NULL,
	[PreferesMountainBike] [bit] NULL,
	[PreferesTouringBike] [bit] NULL,
	[PreferesRoadBike] [bit] NULL,
	[HigherPrice] [money] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_UserPreference_UserPreferenceID] PRIMARY KEY CLUSTERED 
(
	[UserPreferenceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


