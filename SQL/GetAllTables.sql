USE [dbchapoo09]
GO
/****** Object:  StoredProcedure [dbo].[GetMenuItems]    Script Date: 27-5-2020 13:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 27-05-2020 13:01
-- Description: Get All Tables
-- =============================================
CREATE PROCEDURE [dbo].[GetAllTables] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT TableID FROM [Table];
END
