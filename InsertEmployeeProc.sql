-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE CreateEmployee
	-- Add the parameters for the stored procedure here
	@FirstName NVARCHAR(MAX),
	@LastName NVARCHAR(MAX),
	@JobTitle NVARCHAR(MAX) = '',
	@BirthDate Date = NULL,
	@DepartmentId INT = NULL,
	@Id INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;

	Insert Into TestDB.dbo.Employees (FirstName, LastName, JobTitle, DateOfBirth, DepartmentId)
	Values (@FirstName, @LastName, @JobTitle, @BirthDate, @DepartmentId)

	SET @Id = SCOPE_IDENTITY();
END
GO
