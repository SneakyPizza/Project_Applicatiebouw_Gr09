USE [dbchapoo09]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 27-05-2020 13:37
-- Description: Get ReservationID on TableID
-- =============================================
CREATE PROCEDURE [dbo].[GetReservationID] 
@tableID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ReservationID FROM ReservationTable WHERE TableID = @tableID;
END
