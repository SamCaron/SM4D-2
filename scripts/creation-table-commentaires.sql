USE [SM4D]
CREATE TABLE [dbo].[Commentaires](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Prenom] [nvarchar](30) NOT NULL,
	[Nom] [nvarchar](30) NOT NULL,
	[Details] [nvarchar](30) NOT NULL,
	[Contenu] [nvarchar](max) NOT NULL,
	[DateCreation] [datetime] NULL,
	[NomDeFichier] [nvarchar](200) NOT NULL,
);


