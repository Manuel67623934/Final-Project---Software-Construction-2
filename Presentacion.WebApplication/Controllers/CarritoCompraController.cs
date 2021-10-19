using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Presentacion.WebApplication.Models;
using Entidad.ClassLibrary;
using Logica.ClassLibrary;

namespace Presentacion.WebApplication.Controllers
{
    public class CarritoCompraController : Controller
    {
        // GET: CarritoCompra
        public ActionResult Index()
        {
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();

            
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");


            return View("Index", model);
        }

        // GET: CarritoCompra/Details/5
        public ActionResult CrearPDF()
        {
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();
            
            return new ViewAsPdf("index", model)
            {

            };
        }

        // GET: CarritoCompra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarritoCompra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarritoCompra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarritoCompra/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarritoCompra/Delete/5
       
        public ActionResult Delete(int Id)
        {
            ItemCarritoBL.Delete(Id);
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();

            
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

            return View("Index", model);
        }

        // GET: CarritoCompra/Aumenta_Cantidad/

        public ActionResult Aumenta_Cantidad(int Id)
        {

            ItemCarritoBL.AumentaCantidad(Id);
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();


            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

            return View("Index", model);
        }

        // GET: CarritoCompra/Disminuye_Cantidad/

        public ActionResult Disminuye_Cantidad(int Id)
        {

            ItemCarritoBL.DisminuyeCantidad(Id);
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();

            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult AñadirProducto(string cantidad, int Id)
        {
            ItemCarritoBL.CrearItem(cantidad, Id);
             

            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();

            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActualizarCarrito(string cantidad, int Id)
        {

            ItemCarritoBL.ActualizarCarrito(cantidad, Id);


            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoBL.GetAll();
            model.MontoTotalCarrito = ItemCarritoBL.CalculaTotal();

            int c1, c2;
            for (int i = 0; i < model.ItemsCarrito.Count(); i++)
            {
                if (i == 0) {
                    c1 = model.ItemsCarrito[i].Cantidad;
                }
                if (i == 1)
                {
                    c2 = model.ItemsCarrito[i].Cantidad;
                }
            }


                return View("Index", model);
        }

    }
}
