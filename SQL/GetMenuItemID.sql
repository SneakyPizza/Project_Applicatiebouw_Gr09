USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[GetMenuItemID]    Script Date: 27-5-2020 14:16:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 27-05-2020 14:15
-- Description: Get MenuItemID on MenuItemName
-- =============================================
ALTER PROCEDURE [dbo].[GetMenuItemID] 
@menuItemName nvarchar = " "
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MenuItemID FROM MenuItem WHERE MenuItemName = @menuItemName;
END
