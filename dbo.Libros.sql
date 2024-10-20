USE [LibreriaDB]
GO

/****** Objeto: Table [dbo].[Libros] Fecha del script: 20/10/2024 1:09:32 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Libros] (
    [LibroID] INT            IDENTITY (1, 1) NOT NULL,
    [Titulo]  NVARCHAR (200) NOT NULL,
    [AutorID] INT            NULL
);


