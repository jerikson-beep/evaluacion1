USE [LibreriaDB]
GO

/****** Objeto: Table [dbo].[Autores] Fecha del script: 20/10/2024 1:09:11 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Autores] (
    [AutorID] INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]  NVARCHAR (100) NOT NULL
);


