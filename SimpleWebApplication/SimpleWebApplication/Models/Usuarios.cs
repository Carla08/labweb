using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleWebApplication.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String Nombre { get; set; }

        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public NivelPrivilegio Privilegio { get; set; }

    }

    public enum NivelPrivilegio
    {
        Administrador = 1,
        Supervisor = 2,
        Usuario = 3,
    }
    
}