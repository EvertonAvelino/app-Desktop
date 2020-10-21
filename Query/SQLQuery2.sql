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
-- Author:		Everton
-- Create date: 13-10-2020
-- Description:	Criando  procedure para sistema ERP
-- =============================================
CREATE PROCEDURE InserirPessoa
	-- Add the parameters for the stored procedure here
	@nome varchar(50),
	@cpf varchar(15),
	@telefone varchar(20),
	@email varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into pessoas(nome, cpf, telefone, email) values(@nome,@cpf,@telefone ,@email );
	select @@IDENTITY;
END
GO
