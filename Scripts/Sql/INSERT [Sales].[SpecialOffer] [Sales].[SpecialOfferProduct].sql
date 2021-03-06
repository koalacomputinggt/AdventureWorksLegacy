USE [AdventureWorks]
GO
SET IDENTITY_INSERT [Sales].[SpecialOffer] ON 

GO

INSERT [Sales].[SpecialOffer] ([SpecialOfferID], [Description], [DiscountPct], [Type], [Category], [StartDate], [EndDate], [MinQty], [MaxQty], [rowguid], [ModifiedDate]) VALUES (17, N'Seasonal Discount', 0.1000, N'Seasonal Discount', N'Customer', CAST(N'2017-10-01 00:00:00.000' AS DateTime), CAST(N'2017-10-10 00:00:00.000' AS DateTime), 0, NULL, N'1ed85cdc-6208-4163-b5ad-ac61ee69542c', CAST(N'2017-10-01 16:49:58.613' AS DateTime))
GO
SET IDENTITY_INSERT [Sales].[SpecialOffer] OFF
GO

INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 680, N'1977e309-9af7-42ed-8807-8d56595d2f38', CAST(N'2017-10-01 17:05:30.913' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 709, N'83be6290-7c08-4e6b-be00-60dbbb6b7da1', CAST(N'2017-10-01 17:08:58.180' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 710, N'f0d1aebd-b753-4e98-9b04-08f76f3db4a4', CAST(N'2017-10-01 17:05:47.210' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 719, N'd7dbeada-6b16-4b69-9f8b-b514bf7815ef', CAST(N'2017-10-01 17:09:07.083' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 720, N'532b8fd6-8e04-49e8-9a13-b6b1b1783643', CAST(N'2017-10-01 17:05:50.960' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 729, N'd24a6135-d2d8-466a-beec-92cf87987fbf', CAST(N'2017-10-01 17:05:53.310' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 823, N'13f463c3-d654-4d7d-b699-0236d396605b', CAST(N'2017-10-01 17:08:09.823' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 854, N'a6e02e08-f190-412a-9c29-311003c60cb3', CAST(N'2017-10-01 17:08:13.343' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 885, N'7ec068ee-9abb-4469-be8d-56907bf17ce0', CAST(N'2017-10-01 17:05:56.753' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 890, N'b4fc1f7e-0f2d-4abd-af0d-97196e49d128', CAST(N'2017-10-01 17:06:00.827' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 900, N'b15fa5ac-5369-426d-90f2-ee6cc341831f', CAST(N'2017-10-01 17:06:05.347' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 939, N'ee56c330-bf04-481a-a663-2ae0eab91a1e', CAST(N'2017-10-01 17:07:54.210' AS DateTime))
GO
INSERT [Sales].[SpecialOfferProduct] ([SpecialOfferID], [ProductID], [rowguid], [ModifiedDate]) VALUES (17, 941, N'8891b7b0-cf19-4fb1-b27c-07d342bdfcdf', CAST(N'2017-10-01 17:07:57.333' AS DateTime))
GO
