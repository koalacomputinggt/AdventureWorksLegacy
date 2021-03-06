USE [AdventureWorks]
GO
/****** Object:  StoredProcedure [dbo].[uspGetProductsBySubcategory]    Script Date: 09/24/2017 21:35:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspGetProductsBySubcategory]
    @SubcategoryID [int]
AS
BEGIN
    SET NOCOUNT ON;

    -- List out all Products for a particular Subcategory
	SELECT P.ProductID, 
		-- PC.Name AS Category, PSC.Name AS Subcategory,
		PM.Name AS Model, P.Name AS Product, P.ListPrice AS ListPrice, 
		P.Weight AS Weight, UM.Name AS UnitMeasure, 
		PP.ThumbNailPhoto, PP.ThumbnailPhotoFileName
	FROM Production.Product AS P
		FULL JOIN Production.ProductModel AS PM ON PM.ProductModelID = P.ProductModelID
		--FULL JOIN Production.ProductSubcategory AS PSC ON PSC.ProductSubcategoryID = P.ProductSubcategoryID
		--JOIN Production.ProductCategory AS PC ON PC.ProductCategoryID = PSC.ProductCategoryID 
		JOIN Production.UnitMeasure AS UM ON P.WeightUnitMeasureCode = UM.UnitMeasureCode
		JOIN Production.ProductProductPhoto AS PPP ON P.ProductID = PPP.ProductID 
		JOIN Production.ProductPhoto AS PP ON PP.ProductPhotoID = PPP.ProductPhotoID
	WHERE
		P.ProductSubcategoryID = @SubcategoryID
	ORDER BY P.Name; --PC.Name, PSC.Name ;

END;

