USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[GetTableIDAndStatus]    Script Date: 6/12/2020 15:22:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Lars de Groot>
-- Create date: <11-6-2020>
-- Description:	<Get TableID and OrderStatus>
-- =============================================
CREATE PROCEDURE [dbo].[GetTableIDAndStatus] 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [ReservationTable].TableID, [OrderStatus].OrderStatusName FROM [Order]
	JOIN [OrderStatus] ON [OrderStatus].OrderStatusID = [Order].OrderStatusID
	JOIN [Reservation] ON [Order].ReservationID = [Reservation].ReservationID
	JOIN [ReservationTable] ON [ReservationTable].ReservationID = [Reservation].ReservationID;
END
