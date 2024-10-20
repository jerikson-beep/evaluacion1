using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace evaluacion1.Models
{
    public class Libro
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(200, ErrorMessage = "El título no puede tener más de 200 caracteres.")]
        public string Titulo { get; set; }
        public int AutorID { get; set; }
        public virtual Autor Autor { get; set; }
    }
}