using Entidad.ClassLibrary;
using Logica.ClassLibrary;
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
            ProductoBE producto = p.getProducto(Url_Seo);
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            WebModel model_producto = new WebModel()
            {
                producto_solo = producto,
                categoria_layout= lista_categoria
            };

            

            return View(model_producto);
        }
        public ActionResult Login()
        {
            
            return View();
        }

        public ActionResult Categoria (string Url_Seo)
        {
            CategoriaBL categoria = new CategoriaBL();
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            List<ProductoBE> lista_producto = categoria.GetProductos(Url_Seo);
            CategoriaBE cate = new CategoriaBL().ObtenerCategoria(Url_Seo);

            WebModel model = new WebModel()
            {
                prod = lista_producto,
                categoria = cate,
                categoria_layout = lista_categoria,

                LoginCorrecto =1


            };


            return View(model) ;
        }
       
    }
}
