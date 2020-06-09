SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lars de Groot
-- Create date: 9-6-2020
-- Description:	Get most recent OrderID
-- =============================================
CREATE PROCEDURE GetMostRecentOrderID 
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MAX(OrderID) as OrderID 
	FROM [Order];
END
GO
