USE [SM4D]
GO
/****** Object:  StoredProcedure [dbo].[spCommentaires_Ajouter]    Script Date: 2024-01-21 21:52:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spCommentaires_Ajouter]
	-- Add the parameters for the stored procedure here
	@Prenom nvarchar(30),
	@Nom nvarchar(30),
	@Details nvarchar(30),
	@Contenu nvarchar(MAX),
	-- DATETIME_NOW
	@NomDeFichier nvarchar(200)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT * FROM Medias 
	WHERE Medias.NomFichierSM4D = @NomDeFichier) 
		INSERT INTO Commentaires
		VALUES (@Prenom, @Nom, @Details, @Contenu, GETDATE(), @NomDeFichier)
		
END