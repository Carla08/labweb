using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SimpleWebApplication.Models
{
    public class ProyectoCAPA : DbContext
    {
        //Esta es la base de datos como tal
        public DbSet<Usuarios> Usuarios { get; set; }
        public ProyectoCAPA() : base("Name=CAPAdb") { }
        public System.Data.Entity.DbSet<SimpleWebApplication.Models.Reportes> Reportes { get; set; }
    }
}