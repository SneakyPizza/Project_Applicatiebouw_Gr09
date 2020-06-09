USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[PlaceOrder]    Script Date: 27-5-2020 14:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 27-05-2020 14:36
-- Description: Place MenuOrder
-- =============================================
CREATE PROCEDURE [dbo].[PlaceMenuOrder] 
@amount int = 0,
@orderID int = 0,
@menuItemID int = 0

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [MenuOrder] (Amount, OrderID, MenuItemID)
	VALUES (@amount, @orderID, @menuItemID)
END
