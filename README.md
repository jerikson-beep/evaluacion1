# Evaluaci�n1 - Gesti�n de Biblioteca ??

## Descripci�n del Proyecto
Esta es una aplicaci�n web simplificada de gesti�n de biblioteca desarrollada en **ASP.NET MVC** con **C#**. Permite a los usuarios gestionar libros y autores mediante una interfaz amigable. Se conect� a una base de datos SQL Server utilizando **Entity Framework**.

---

## Funcionalidades Principales
1. **P�gina Principal**:
   - Ver lista de libros disponibles.
   - Agregar un nuevo libro.
   - Agregar un nuevo autor.

2. **Gesti�n de Libros**:
   - Formulario para agregar un libro indicando el **t�tulo** y el **autor** (seleccionado de una lista desplegable).

3. **Gesti�n de Autores**:
   - Formulario para agregar un nuevo autor indicando su **nombre**.

---

## Requisitos Previos
- **Visual Studio** 2022 o superior.
- **SQL Server** instalado y configurado.
- **Entity Framework** integrado en el proyecto.
- Clonar este repositorio:  
  ```bash
  git clone https://github.com/jerikson-beep/evaluacion1.git

Pasos para Configurar y Ejecutar la Aplicaci�n
Configura la base de datos:

Abre SQL Server Management Studio (SSMS).
Ejecuta el script libreriaBD_script.sql que se encuentra en la carpeta ra�z del proyecto para crear las tablas necesarias:
sql
Copiar c�digo
-- Script de ejemplo
CREATE DATABASE LibreriaBD;
USE LibreriaBD;
CREATE TABLE Autores (
    AutorID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL
);
CREATE TABLE Libros (
    ID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(100) NOT NULL,
    AutorID INT FOREIGN KEY REFERENCES Autores(AutorID)
);
Configura la cadena de conexi�n:

En Visual Studio, abre el archivo appsettings.json o Web.config (seg�n corresponda) y aseg�rate de que la cadena de conexi�n sea correcta:

  <connectionStrings>
    <add name="BibliotecaContext" connectionString="Server=(localdb)\MSSQLLocalDB;Database=bibliotecabd;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
  
  Ejecuta la Aplicaci�n:

Abre el proyecto en Visual Studio.
Restaura los paquetes NuGet necesarios.
Presiona F5 para ejecutar la aplicaci�n en el navegador.

## Capturas de Pantalla

**imagen 1**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen1.jpg)

**imagen 2**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen2.jpg)
**imagen 3**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen3.jpg)
**imagen 4**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen4.jpg)
**imagen 5**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen5.jpg)
**imagen 6**  
![
![P�gina Principal](imagen
P�gina Principal](imagenes/imagen6.jpg)

+------------------+       1           *      +----------------+
|     Autores      |--------------------------|     Libros      |
+------------------+                          +----------------+
| AutorID (PK)     |                          | ID (PK)         |
| Nombre           |                          | Titulo          |
+------------------+                          | AutorID (FK)     |
                                              +----------------+
Descripci�n del Diagrama ER
Autores :
Tiene un identificador �nico AutorIDcomo Clave Primaria (PK) .
Guarda el nombre del autor .
Libros :
Tiene un identificador �nico IDcomo **Clave Primaria (PClave Primaria (PK) .
Guarda el t�tulo del libro .
AutorIDes una **Clave FoClave For�nea (FK)Autores , estableciendo una relaci�n **uno a muchos (1uno a muchos (1
) entre a

Enlace al Repositorio
https://github.com/jerikson-beep/evaluacion1.git
Autor
Jerikson Andrey Acero
Proyecto de Evaluaci�n - ASP.NET MVC

