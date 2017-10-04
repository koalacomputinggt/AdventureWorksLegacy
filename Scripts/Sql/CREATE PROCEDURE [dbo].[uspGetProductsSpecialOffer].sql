USE [AdventureWorks]
GO

/****** Object:  StoredProcedure [dbo].[uspGetProductsSpecialOffer]    Script Date: 04/10/2017 11:06:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[uspGetProductsSpecialOffer]
	@SpecialOfferID [int]
AS
BEGIN
	-- List out all Products for a particular special offer
	SELECT P.ProductID, 
		ISNULL(PM.Name,'') AS Model, P.Name AS Product, P.ListPrice AS ListPrice, 
		ISNULL(P.[Weight],0) AS [Weight], ISNULL(UM.Name,'') AS UnitMeasure, P.Color,
		PP.ThumbNailPhoto, PP.ThumbnailPhotoFileName, SO.DiscountPct
	FROM Production.Product AS P
		FULL JOIN Production.ProductModel AS PM ON PM.ProductModelID = P.ProductModelID
		LEFT OUTER JOIN Production.UnitMeasure AS UM ON P.WeightUnitMeasureCode = UM.UnitMeasureCode
		LEFT OUTER JOIN Production.ProductProductPhoto AS PPP ON P.ProductID = PPP.ProductID 
		LEFT OUTER JOIN Production.ProductPhoto AS PP ON PP.ProductPhotoID = PPP.ProductPhotoID
		JOIN Sales.SpecialOfferProduct AS SOP ON P.ProductID = SOP.ProductID
		JOIN Sales.SpecialOffer AS SO ON SOP.SpecialOfferID = SO.SpecialOfferID
	WHERE
		SOP.SpecialOfferID = @SpecialOfferID
	ORDER BY P.Name; 

END;



GO


