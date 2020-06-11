USE [dbchapoo09]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Yornie Westink
-- Create date: 25/5
-- Description:	search for employee with email and password
-- =============================================
CREATE PROCEDURE [GetEmployee]
	-- Add the parameters for the stored procedure here
	@email nvarchar(200),
	@password nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT EmployeeID, FirstName, LastName, EmailAdress, [Password], [Employee].[FunctionID], [Function].FunctionName 
	FROM [Employee] 
	JOIN [Function] ON [Employee].FunctionID = [Function].FunctionID
	WHERE EmailAdress = @email AND [Password] = @password;
END
GO
