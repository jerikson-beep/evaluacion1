# Evaluación1 - Gestión de Biblioteca ??

## Descripción del Proyecto
Esta es una aplicación web simplificada de gestión de biblioteca desarrollada en **ASP.NET MVC** con **C#**. Permite a los usuarios gestionar libros y autores mediante una interfaz amigable. Se conectó a una base de datos SQL Server utilizando **Entity Framework**.

---

## Funcionalidades Principales
1. **Página Principal**:
   - Ver lista de libros disponibles.
   - Agregar un nuevo libro.
   - Agregar un nuevo autor.

2. **Gestión de Libros**:
   - Formulario para agregar un libro indicando el **título** y el **autor** (seleccionado de una lista desplegable).

3. **Gestión de Autores**:
   - Formulario para agregar un nuevo autor indicando su **nombre**.

---

## Requisitos Previos
- **Visual Studio** 2022 o superior.
- **SQL Server** instalado y configurado.
- **Entity Framework** integrado en el proyecto.
- Clonar este repositorio:  
  ```bash
  git clone https://github.com/jerikson-beep/evaluacion1.git

Pasos para Configurar y Ejecutar la Aplicación
Configura la base de datos:

Abre SQL Server Management Studio (SSMS).
Ejecuta el script libreriaBD_script.sql que se encuentra en la carpeta raíz del proyecto para crear las tablas necesarias:
sql
Copiar código
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
Configura la cadena de conexión:

En Visual Studio, abre el archivo appsettings.json o Web.config (según corresponda) y asegúrate de que la cadena de conexión sea correcta:

  <connectionStrings>
    <add name="BibliotecaContext" connectionString="Server=(localdb)\MSSQLLocalDB;Database=bibliotecabd;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
  </connectionStrings>
  
  Ejecuta la Aplicación:

Abre el proyecto en Visual Studio.
Restaura los paquetes NuGet necesarios.
Presiona F5 para ejecutar la aplicación en el navegador.

## Capturas de Pantalla

**imagen 1**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen1.jpg)

**imagen 2**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen2.jpg)
**imagen 3**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen3.jpg)
**imagen 4**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen4.jpg)
**imagen 5**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen5.jpg)
**imagen 6**  
![
![Página Principal](imagen
Página Principal](imagenes/imagen6.jpg)



+------------------+       1           *      +----------------+
|     Autores      |--------------------------|     Libros      |
+------------------+                          +----------------+
| AutorID (PK)     |                          | ID (PK)         |
| Nombre           |                          | Titulo          |
+------------------+                          | AutorID (FK)     |
                                              +----------------+



Descripción del Diagrama ER
Autores :
Tiene un identificador único AutorIDcomo Clave Primaria (PK) .
Guarda el nombre del autor .
Libros :
Tiene un identificador único IDcomo **Clave Primaria (PClave Primaria (PK) .
Guarda el título del libro .
AutorIDes una **Clave FoClave Foránea (FK)Autores , estableciendo una relación **uno a muchos (1uno a muchos (1
) entre a

Enlace al Repositorio
https://github.com/jerikson-beep/evaluacion1.git

Autor
Jerikson Andrey Acero
Proyecto de Evaluación - ASP.NET MVC

