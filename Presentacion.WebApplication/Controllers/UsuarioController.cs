using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidad.ClassLibrary;
using Logica.ClassLibrary;
using Presentacion.WebApplication.Models;
using System.Security.Claims;
using System.Web;

namespace Presentacion.WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int seleccion)
        {
            List<CategoriaEntidad> listaCategoria = new CategoriaLogica().ObtenerCategorias();
            WebModel model = new WebModel();
            model.categoria_layout = listaCategoria;
            model.tipoLogin = seleccion;
            model.enSession = 0;
            model.usuario = UsuarioLogica.ObtenerUnicoUsuario(0);
            model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            if (model.tipoLogin == 1)
            {
                model.tipoLoginNombre = "Login Correo";
                return View(model);
            }
            else
            {
                model.tipoLoginNombre = "Login Celular";
                return View(model);
            }
        }

        public ActionResult Registro()
        {
            List<CategoriaEntidad> listaCategoria = new CategoriaLogica().ObtenerCategorias();
            WebModel tipoLogin = new WebModel();
            tipoLogin.categoria_layout = listaCategoria;
            tipoLogin.Estado_Session = HttpContext.Session.GetString("Estado_Session");
            //return View(tipoLogin);
            return View("../Usuario/Registration", tipoLogin);
        }      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(string nombre, string apellido, string dirección, string referencia, string celular, string correo, string contraseña)
        {
            WebModel model = new WebModel();
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            try
            {                
                UsuarioEntidad usuarioTemporal = new UsuarioEntidad();
                usuarioTemporal.Id = 1;
                usuarioTemporal.Nombres = nombre;
                usuarioTemporal.Apellido = apellido;
                usuarioTemporal.Direccion = dirección;
                usuarioTemporal.Referencia = referencia;
                usuarioTemporal.NumeroCelular = celular;
                usuarioTemporal.Usuario = correo;
                usuarioTemporal.Contraseña = contraseña;
                UsuarioLogica.AgregarUsuarios(usuarioTemporal);                
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                return View("../Home/Index", model);
            }
            catch
            {
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                return View("../Home/Index", model);
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ValidarLogin(string usr= "indefinido", string phone ="indefinido", string pwd ="indefinido")
        {
            WebModel model = new WebModel();
            List<CategoriaEntidad> categoria = new CategoriaLogica().ObtenerCategorias();
            List<ProductoEntidad> producto = new ProductoBL().ObtenerProductos();
            model.prod = producto;
            model.categoria_layout = categoria;
            int loginCorreto = UsuarioLogica.LoginCorrecto(usr, phone, pwd);     
            if (loginCorreto == 1)
            {
                int idUser = UsuarioLogica.ObtenerId(usr, phone);
                HttpContext.Session.SetInt32("Id_cliente_activo", idUser);                
                model.usuario = UsuarioLogica.ObtenerUnicoUsuario(idUser);                
                HttpContext.Session.SetString("Estado_Session", "activo");
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");          
                return View("../Home/Index", model);
            }
            else
            {
                model.enSession = 0;
                model.loginCorrecto = 0;                
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                return View("../Usuario/Login", model);
            }      
        }
    }
}
