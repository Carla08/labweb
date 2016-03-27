using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SimpleWebApplication.Models
{
    public class Reportes
    {
        [Key]
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Estatus { get; set; }

        public DateTime Fecha { get; set; }

        [DisplayName("Responsable")]
        public int UsuarioId { get; set; }

        //Este va a guardar los datos
        public Usuarios Responsable { get; set; }

    }
}