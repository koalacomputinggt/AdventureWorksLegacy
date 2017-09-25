USE [AdventureWorks]
GO

SET IDENTITY_INSERT [Membership].[Profile] ON 

GO
INSERT [Membership].[Profile] ([ProfileID], [UserID], [FirstName], [MiddleName], [LastName], [BirthDate], [Gender], [MaritalStatus], [HasChildren], [AddressLine1], [AddressLine2], [City], [State], [ZipCode], [Country], [TimeZone], [CreatedDate], [ModifiedDate]) VALUES (1, 2, N'Beta', N'User', N'User', CAST(N'1973-07-06 00:00:00.000' AS DateTime), N'M', 1, 1, N'3315 Brickell Ave.', N'Ste. 108', N'Miami', N'FL', N'33131', 1, N'MT        ', CAST(N'2017-09-24 20:04:00.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [Membership].[Profile] OFF
GO