using Microsoft.AspNetCore.Mvc;
using Presentacion.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Controllers
{
    public class WebController : Controller
    {
        public ActionResult Login()
        {
            
            return View();
        }
       
    }
}
