USE [SM4D]
GO
/****** Object:  StoredProcedure [dbo].[spCommentaires_GetCommentaireDuMedia]    Script Date: 2024-01-13 23:00:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Caron, Samuel>
-- Create date: <2024-01-07>
-- Description:	<Récupère les commentaires d'un média>
-- =============================================
CREATE PROCEDURE [dbo].[spCommentaires_GetCommentaireDuMedia] 
	-- Add the parameters for the stored procedure here
	@NomFichier nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Commentaires
	WHERE Commentaires.NomDeFichier like '%'+@NomFichier+'%'
	ORDER BY Commentaires.DateCreation DESC
END
