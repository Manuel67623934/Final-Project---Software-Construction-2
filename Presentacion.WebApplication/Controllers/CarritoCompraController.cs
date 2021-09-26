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
            UsuarioModel usuarioLogeado = new UsuarioModel();
           


            
            return View("Index");
        }

        // GET: CarritoCompra/Details/5
        public ActionResult CrearPDF()
        {
            return new ViewAsPdf("index")
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CarritoCompra/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
