using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimpleWebApplication.Models;

namespace SimpleWebApplication.Controllers
{
    public class UsersLogInController : Controller
    {
       private ProyectoCAPA db = new ProyectoCAPA();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LogIn(string username, string password)
        {
            var user = from Usuario in db.Usuarios
                       where Usuario.Nombre.Equals(username)
                       select Usuario.Nombre + " " + Usuario.Id;
            if (user != null) {
                return View();
            } else {
                Index();
                Console.WriteLine("No such username");
                return null;
            }
        }
    }
}
