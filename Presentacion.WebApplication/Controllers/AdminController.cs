using Microsoft.AspNetCore.Mvc;
using Presentacion.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whatsapp.ClassLibrary;

namespace Presentacion.WebApplication.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            string mensaje = "no entregado";
            AdminModel model = new AdminModel()
            {
                mensaje =mensaje
            };
            return View(model);
        }
        public ActionResult EnviarMensaje(string mensaje)
        {
            string mensaje_confirmacion = new WhatsappAPI().EnviarWhatsapp(mensaje);
            AdminModel model = new AdminModel()
            {
                mensaje = mensaje_confirmacion
            };
            return View ("Index",model);
        }
    }

}
