USE [AdventureWorks]
GO
/****** Object:  StoredProcedure [dbo].[uspGetUser]    Script Date: 09/24/2017 21:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspGetUser]
    @Email varchar(150)
AS
BEGIN
    SET NOCOUNT ON;

    -- Returns the profile for a particular user
	SELECT u.[UserID]
		, u.[Email]
		, u.[PasswordHash]
		, u.[PasswordSalt]
		, u.[CreatedDate]
		, u.[ModifiedDate]
		, u.[Status]
        , p.[FirstName]
        , p.[LastName]
	FROM 
		Membership.[User] AS u 
		INNER JOIN Membership.Profile p ON u.UserID = p.UserID
	WHERE
		u.[Email] = @Email

END;

