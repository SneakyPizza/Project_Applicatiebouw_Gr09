USE [dbchapoo09]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 27-05-2020 13:15
-- Description: Place Order
-- =============================================
CREATE PROCEDURE [dbo].[PlaceOrder] 
@orderStatus int = 0,
@reservationID int = 0,
@paymentID int = 0,
@employeeID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [Order] (OrderStatus, ReservationID, PaymentID, EmployeeID)
	VALUES (@orderStatus, @reservationID, @paymentID, @employeeID)
END
