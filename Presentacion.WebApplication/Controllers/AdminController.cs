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
        AdminModel model = new AdminModel();
        public ActionResult Index()
        {
            string mensaje = "no entregado";
            model.mensaje = mensaje;
            return View(model);
        }
        /*public ActionResult EnviarMensaje(string mensaje)
        {
            string mensaje_confirmacion = new WhatsappAPI().EnviarWhatsapp(mensaje);
            model.mensaje = mensaje_confirmacion;
            return View ("Index",model);
        }*/
    }
}
