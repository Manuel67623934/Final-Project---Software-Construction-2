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
using Whatsapp.ClassLibrary;

namespace Presentacion.WebApplication.Controllers
{
    public class CarritoCompraController : Controller
    {
        WhatsappAPI _whatsapp = new WhatsappAPI();
        public ActionResult Index()
        {
            WebModel model = new WebModel();
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            model.ItemsCarrito = ItemCarritoLogica.ObtenerTodo();
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");            
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();
            return View("Index", model);
        }

        public ActionResult CrearPDF()
        {
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoLogica.ObtenerTodo();
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            return new ViewAsPdf("index", model);            
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete(int Id)
        {
            ItemCarritoLogica.Eliminar(Id);
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoLogica.ObtenerTodo();
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            return View("Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AñadirProducto(string cantidad, int Id)
        {
            ItemCarritoLogica.CrearItem(cantidad, Id);     
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoLogica.ObtenerTodo();
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();            
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            model.idUsuario = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario((int)HttpContext.Session.GetInt32("Id_cliente_activo"));
            return View("../Home/Index", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActualizarCarrito(string cantidad, int Id)
        {
            ItemCarritoLogica.ActualizarCarrito(cantidad, Id);
            WebModel model = new WebModel();
            model.ItemsCarrito = ItemCarritoLogica.ObtenerTodo();
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            return View("Index", model);
        }

        public ActionResult ApiWsp()         
        {
            WebModel model = new WebModel();
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            model.MontoTotalCarrito = ItemCarritoLogica.CalculaTotal();
            string msg =
                "Cliente : " + model.usuario.Nombres + "  " + model.usuario.Apellido + "\n" +
                "Telefono: " + model.usuario.NumeroCelular + "\n" +
                "Dirección: " + model.usuario.Direccion + " - " + model.usuario.Referencia + "\n" +
                "Lista de compra : \n" + ItemCarritoLogica.ListaProductos() + "\n" +
                "Total -----> " + model.MontoTotalCarrito;
            _whatsapp.EnviarWhatsapp(msg);
            ItemCarritoLogica.LimpiarCarrito();
            return RedirectToAction("Index", "Home");
        }
    }
}
