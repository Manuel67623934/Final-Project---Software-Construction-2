using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Controllers
{
    public class ProductoController : Controller
    {
        //GET: ProductoController
        public ActionResult Index()
        {
            return View();
        }
    }
}
