USE [AdventureWorks]
GO

SET IDENTITY_INSERT [Membership].[User] ON 

GO
INSERT [Membership].[User] ([UserID], [Email], [PasswordHash], [PasswordSalt], [CreatedDate], [ModifiedDate], [Status]) VALUES (2, N'user@kloudala.com', N'$2a$10$AN1oG.RdEtoLTVF2yUWoIeQU9INv8nQEIcqtZhG32Hi7v69JHOLt.                                        ', N'^Y8~JJ', CAST(N'2017-09-24 20:01:00.000' AS DateTime), CAST(N'2017-09-24 20:01:00.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [Membership].[User] OFF
GO