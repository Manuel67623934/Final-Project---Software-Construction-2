using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Entidad.ClassLibrary;
using Dato.ClassLibrary;

namespace ProyectoMinimarketMVC.Controllers
{
    public class CrearPDFController : Controller
    {
        public IActionResult Index()
        {

            //List<ItemCarritoBE> itemsCarritoLista = ItemCarritoDA.GetAll();
            //ItemCarritoBE itemCarrito = new ItemCarritoBE();
            
            return new ViewAsPdf("Index")
            {
                
            };
        }
    }
}
