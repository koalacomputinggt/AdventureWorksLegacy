USE [AdventureWorks]
GO

/****** Object:  StoredProcedure [dbo].[uspGetSpecialOffer]    Script Date: 02/10/2017 12:07:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[uspGetSpecialOffer]
	@Date [datetime]
AS
BEGIN
	SET NOCOUNT ON

	-- Get the current offer
	SELECT
		SO.SpecialOfferID, 
		SO.[Description] AS [Description],
		SO.DiscountPct AS [DiscountPct],
		SO.StartDate AS [StartDate],
		SO.EndDate AS [EndDate]
	FROM Sales.SpecialOffer AS SO
	WHERE 
		@Date BETWEEN SO.StartDate AND SO.EndDate


END;



GO


