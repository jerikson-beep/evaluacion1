using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace evaluacion1.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaContext") { }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}