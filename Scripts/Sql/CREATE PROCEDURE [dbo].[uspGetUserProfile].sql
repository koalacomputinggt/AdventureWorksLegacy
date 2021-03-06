USE [AdventureWorks]
GO
/****** Object:  StoredProcedure [dbo].[uspGetUserProfile]    Script Date: 09/24/2017 21:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspGetUserProfile]
    @UserID [int]
AS
BEGIN
    SET NOCOUNT ON;

    -- Returns the profile for a particular user
	SELECT p.[ProfileID]
      ,p.[UserID]
      --,u.[Email]
      ,p.[FirstName]
      ,p.[MiddleName]
      ,p.[LastName]
      ,p.[BirthDate]
      ,p.[Gender]
      ,p.[MaritalStatus]
      ,p.[HasChildren]
      ,p.[AddressLine1]
      ,p.[AddressLine2]
      ,p.[City]
      ,p.[State]
      ,p.[ZipCode]
      ,p.[Country]
      ,p.[TimeZone]
	  ,p.[CreatedDate]
      ,p.[ModifiedDate]
	FROM Membership.Profile AS p 
		--INNER JOIN Membership.User AS u ON p.UserID = u.UserID
	WHERE
		p.UserID = @UserID

END;

