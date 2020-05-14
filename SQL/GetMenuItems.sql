SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 14-05-2020 10:33
-- Description: Get Menu Items
-- =============================================
CREATE PROCEDURE GetMenuItems 
	-- Add the parameters for the stored procedure here
@MenuTypeID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MenuItemID, MenuItemName, ShelfLife, PricePP FROM MenuItem WHERE MenuTypeID = @MenuTypeID
END
GO
