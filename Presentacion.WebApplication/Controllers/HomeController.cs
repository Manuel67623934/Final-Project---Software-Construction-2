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

                                   
            if(seleccion == 1)
            {
                model.enSession = 1;               
                return View ("../CarritoCompra/Index");
            }
            else
            {
                UsuarioBL.cerrarSession(seleccion);
                model.enSession = UsuarioBL.verificarSession(seleccion);
                return View(model);
            }


        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
