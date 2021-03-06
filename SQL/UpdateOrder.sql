USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 6/12/2020 15:23:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink	
-- Create date: 12/6
-- Description:	Update Menu Order with new status
-- =============================================
CREATE PROCEDURE [dbo].[UpdateOrder] 
	-- Add the parameters for the stored procedure here
	@statusID int,
	@orderID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [Order]
	SET [OrderStatusID] = @statusID
	WHERE OrderID = @orderID
END
