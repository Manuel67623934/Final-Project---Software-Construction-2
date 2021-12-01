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

        static int _numeroIngreso = 0;
        public IActionResult Inicializar()
        {
            HttpContext.Session.SetInt32("Id_cliente_activo", 0);
            HttpContext.Session.SetString("Estado_Session", "desactivado");
            return RedirectToAction("Index", "Home");            
        }
        
        
        public IActionResult Index()
        {            
            // Iniciar lista de productos.
            WebModel model = new WebModel();
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            // Ingreso primera vez.            
            if ( _numeroIngreso == 0)
            {
                _numeroIngreso++;
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                return View(model);
            }
            // Pasar por Home IndeX más de 1 vez.
            else
            {                             
                // Cliente logeado quiere seguir navegando en la web.
                string estadoSession = HttpContext.Session.GetString("Estado_Session");
                if (estadoSession == "activo")
                {
                    model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                    int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
                    model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
                    return View(model);
                }
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                int cliente_activo_1 = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
                model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo_1);
                return View(model);
            }
        }

        // Se encarga de cerras sesion del usuario (al cerrar la sesion se borra los items del carrito de compras).

        public IActionResult CerrarSesion(int seleccion)
        {
            WebModel model = new WebModel();
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;

            if (seleccion == 1)
            {
                return RedirectToAction("Index", "CarritoCompra");                
            }
            else
            {
                ItemCarritoLogica.LimpiarCarrito();
                HttpContext.Session.SetString("Estado_Session", "desactivado");
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                HttpContext.Session.SetInt32("Id_cliente_activo", 0);
                return View("../Home/Index", model);
            }
        }


        // Cambiar idioma - inicio.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }
        

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
