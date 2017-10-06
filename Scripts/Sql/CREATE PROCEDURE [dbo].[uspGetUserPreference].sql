USE [AdventureWorks]
GO

/****** Object:  StoredProcedure [dbo].[uspGetUserPreference]    Script Date: 04/10/2017 18:17:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[uspGetUserPreference]
    @UserID [int]
AS
BEGIN
    SET NOCOUNT ON;

    -- Returns the profile for a particular user
	SELECT up.[UserPreferenceID]
      ,up.[UserID]
	  ,up.[LikesBlack]
	  ,up.[LikesBlue]
	  ,up.[LikesGrey]
	  ,up.[LikesMulti]
	  ,up.[LikesRed]
	  ,up.[LikesSilver]
	  ,up.[LikesWhite]
	  ,up.[LikesYellow]
	  ,up.[PreferesMountainBike]
	  ,up.[PreferesTouringBike]
	  ,up.[PreferesRoadBike]
	  ,up.[HigherPrice]
	  ,up.[CreatedDate]
      ,up.[ModifiedDate]
	FROM Membership.UserPreference AS up 
	WHERE
		up.UserID = @UserID

END;



GO


