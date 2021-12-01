using Entidad.ClassLibrary;
using Logica.ClassLibrary;
using Microsoft.AspNetCore.Http;
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
        public ActionResult Producto(string Url_Seo)
        {
            ProductoBL p = new ProductoBL();
            ProductoEntidad producto = p.ObtenerProducto(Url_Seo);
            List<CategoriaEntidad> lista_categoria = new CategoriaLogica().ObtenerCategorias();
            CategoriaEntidad cate = new CategoriaLogica().ObtenerCategoriaProducto(Url_Seo);
            WebModel model_producto = new WebModel()
            {
                producto_solo = producto,
                categoria_layout = lista_categoria,
                categoria = cate,
                //usuario = UsuarioLogica.BuscarUsuarioSessionActiva()                           
            };
            model_producto.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model_producto.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            return View(model_producto);
        }
        public ActionResult Login()
        {            
            return View();
        }

        public ActionResult Categoria (string Url_Seo)
        {
            CategoriaLogica categoria = new CategoriaLogica();
            List<CategoriaEntidad> lista_categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> lista_producto = categoria.ObtenerProductos(Url_Seo);
            CategoriaEntidad cate = new CategoriaLogica().ObtenerCategoria(Url_Seo);
            WebModel model = new WebModel()
            {
                prod = lista_producto,
                categoria = cate,
                categoria_layout = lista_categoria,
                enSession = 1,                                
                Estado_Session = HttpContext.Session.GetString("Estado_Session")
            };
            int cliente_activo = (int)HttpContext.Session.GetInt32("Id_cliente_activo");
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(cliente_activo);
            return View(model) ;
        }       
    }
}
