using Entidad.ClassLibrary;
using Logica.ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentacion.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Localization;

namespace Presentacion.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int seleccion = 0)
        {
            
            
            WebModel model = new WebModel();
            List<CategoriaBE> categoria = new CategoriaBL().getCategorias();
            List<ProductoBE> producto = new ProductoBL().GetProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            model.enSession = 0;
            model.usuario = UsuarioBL.BuscarUsuarioSessionActiva();
                                   
            if(seleccion == 1)
            {
                model.enSession = 1;
                model.ItemsCarrito = ItemCarritoBL.GetAll();
                model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();

                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

                return View ("../CarritoCompra/Index", model);
            }
            else
            {
                UsuarioBL.cerrarSession(seleccion);
                UsuarioBL.abrirSesion(0);
                model.enSession = UsuarioBL.verificarSession(seleccion);


                string en_session = "desactivado";
                HttpContext.Session.SetString("Estado_Session", en_session);
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

                return View(model);
            }


        }


        // change language --- inicio

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }



        //change language --- cierrre


        public IActionResult Privacy()
        {
            WebModel model = new WebModel();
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
