using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using System.IO;
using System.Web.Hosting;


namespace ProyectoMinimarket.HtmltopdfAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public string Get(string url)
        {
            byte[] data = HTMLtoPDF(url);
            return Convert.ToBase64String(data);
        }
        public byte[] HTMLtoPDF(string url)
        {
            //Initialize the HTML to PDF converter
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            WebKitConverterSettings webKitSettings = new WebKitConverterSettings();
            webKitSettings.WebKitPath = HostingEnvironment.MapPath("~/QtBinaries");
            //Assign the WebKit settings to HTML to PDF converter 
            htmlConverter.ConverterSettings = webKitSettings;
            //Convert url to pdf
            PdfDocument document = htmlConverter.Convert(url);
            MemoryStream stream = new MemoryStream();
            //Save and close the PDF document 
            document.Save(stream);
            document.Close(true);
            return stream.ToArray();
        }



    }
}
