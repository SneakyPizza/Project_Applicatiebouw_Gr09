
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 9-6-2020
-- Description:	Voorraad bijwerken
-- =============================================
CREATE PROCEDURE UpdateStock
	-- Add the parameters for the stored procedure here
	@amount int = 0,
	@menuItemID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE MenuItem
	SET Stock = Stock - @amount 
	WHERE MenuItemID = @menuItemID; 
END
GO
