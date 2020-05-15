USE [dbchapoo09]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 15-05-2020 12:30
-- Description: Get Menu Item On ID
-- =============================================
CREATE PROCEDURE GetMenuItemOnID 
	-- Add the parameters for the stored procedure here
@MenuItemID int = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MenuItemID, MenuItemName FROM MenuItem WHERE MenuItemID = @MenuItemID
END
GO
