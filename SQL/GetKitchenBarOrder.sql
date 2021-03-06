USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[GetKitchenBarOrders]    Script Date: 6/12/2020 15:18:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 10/5
-- Description:	Get all kitchen and bar orders
-- =============================================
CREATE PROCEDURE [dbo].[GetKitchenBarOrders]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Order].OrderID, [OrderStatus].OrderStatusName, [Order].ReservationID, 
	[MenuOrder].Amount, 
	[MenuItem].MenuItemID, [MenuItem].MenuItemName, [MenuItem].ShelfLife, [MenuItem].PricePP, [MenuItem].MenuTypeID,
	[ReservationTable].TableID
	FROM [Order] 
	JOIN [MenuOrder] ON [Order].OrderID = [MenuOrder].OrderID
	JOIN [MenuItem] ON [MenuOrder].MenuItemID = [MenuItem].MenuItemID
	JOIN [OrderStatus] ON [OrderStatus].OrderStatusID = [Order].OrderStatusID
	JOIN [Reservation] ON [Order].ReservationID = [Reservation].ReservationID
	JOIN [ReservationTable] ON [ReservationTable].ReservationID = [Reservation].ReservationID
END
