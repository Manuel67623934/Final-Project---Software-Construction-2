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
        // GET: UsuarioController


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int seleccion)
        {
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            WebModel model = new WebModel();
            model.categoria_layout = lista_categoria;
            model.tipoLogin = seleccion;
            model.enSession = 0;
            model.usuario = UsuarioBL.BuscarUsuarioSessionActiva();
            

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


        public ActionResult Registration()
        {
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            WebModel tipoLogin = new WebModel();
            tipoLogin.categoria_layout = lista_categoria;
            

            return View(tipoLogin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        


        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string nombre, string apellido, string dirección, string referencia, string celular, string correo, string contraseña)
        {

            WebModel model = new WebModel();
            List<CategoriaBE> categoria = new CategoriaBL().getCategorias();
            List<ProductoBE> producto = new ProductoBL().GetProductos();
            model.prod = producto;
            model.categoria_layout = categoria;


            try
            {
                
                UsuarioBE usuarioTemporal = new UsuarioBE();
                usuarioTemporal.Id = 1;
                usuarioTemporal.FirtsName = nombre;
                usuarioTemporal.LastsName = apellido;
                usuarioTemporal.Address = dirección;
                usuarioTemporal.Reference = referencia;
                usuarioTemporal.NumberPhone = celular;
                usuarioTemporal.User = correo;
                usuarioTemporal.Password = contraseña;

                UsuarioBL.addUsuarios(usuarioTemporal);

                
                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");

                return View("../Home/Index", model);
            }
            catch
            {


                model.Estado_Session = HttpContext.Session.GetString("Estado_Session");
                return View("../Home/Index", model);
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
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

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
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





        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ValidarLogin(string usr= "indefinido", string phone ="indefinido", string pwd ="indefinido")
        {

            WebModel model = new WebModel();
            List<CategoriaBE> categoria = new CategoriaBL().getCategorias();
            List<ProductoBE> producto = new ProductoBL().GetProductos();
            model.prod = producto;
            model.categoria_layout = categoria;


            int loginCorreto = UsuarioBL.loginCorrecto(usr, phone, pwd);            
           

            if (loginCorreto == 1)
            {
                int idUser = UsuarioBL.GetId(usr, phone);
                UsuarioBL.abrirSesion(idUser);
                UsuarioBL.cerrarSession(0);
                model.loginCorrecto = 1;

                model.usuario = UsuarioBL.GetUserUnic(idUser);               
                model.enSession = UsuarioBL.verificarSession(idUser);

                string en_session = "activo";
                HttpContext.Session.SetString("Estado_Session", en_session);
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
