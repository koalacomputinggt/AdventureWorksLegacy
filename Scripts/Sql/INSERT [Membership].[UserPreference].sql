USE [AdventureWorks]
GO
SET IDENTITY_INSERT [Membership].[UserPreference] ON 

GO
INSERT [Membership].[UserPreference] ([UserPreferenceID], [UserID], [LikesBlack], [LikesBlue], [LikesGrey], [LikesMulti], [LikesRed], [LikesSilver], [LikesWhite], [LikesYellow], [PreferesMountainBike], [PreferesTouringBike], [PreferesRoadBike], [HigherPrice], [CreatedDate], [ModifiedDate]) VALUES (2, 2, 1, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 10000.0000, CAST(N'2017-10-04 12:38:00.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [Membership].[UserPreference] OFF
GO
