using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace evaluacion1.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
    }
}