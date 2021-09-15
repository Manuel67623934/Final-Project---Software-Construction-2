using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;


namespace ProyectoMiniMarketWebApplication.Controller
{
    public class HomeController : ControllerBase
    {
        [HttpPost]
        public IActionResult Index(string submit)
        {
            HtmlToPdfConverter convertir = new HtmlToPdfConverter();

            WebKitConverterSettings settings = new WebKitConverterSettings();
            
            
            return View();
        }
    }
}
