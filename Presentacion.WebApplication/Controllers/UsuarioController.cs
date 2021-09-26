using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entidad.ClassLibrary;
using Logica.ClassLibrary;
using Presentacion.WebApplication.Models;

namespace Presentacion.WebApplication.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: UsuarioController

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(int select)
        {
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            WebModel tipoLogin = new WebModel();
            tipoLogin.categoria_layout = lista_categoria;
            tipoLogin.Id = select;
            
            

            if (tipoLogin.Id == 1)
            {
                tipoLogin.tipoLoginNombre = "Login Correo";
                return View(tipoLogin);
            }
            else
            {
                tipoLogin.tipoLoginNombre = "Login Celular";
                return View(tipoLogin);
            }

        }


        public ActionResult Registration()
        {
            List<CategoriaBE> lista_categoria = new CategoriaBL().getCategorias();
            WebModel model = new WebModel() {
                categoria_layout = lista_categoria
            };
            return View(model);
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


                return View("../Usuario/Login");
            }
            catch
            {
                return View("../Usuario/Login");
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
        public ActionResult ValidarLogin(string usr = "indefinido", string phone = "indefinido", string pwd="passs")
        {

            List<CategoriaBE> categoria = new CategoriaBL().getCategorias();
            List<ProductoBE> producto = new ProductoBL().GetProductos();
            WebModel model = new WebModel()
            {
                prod = producto,
                categoria_layout = categoria,
                prueba = "holamundo",
                LoginCorrecto = 1,
                Id = 1
            };


            bool loginExitosoUser = false;
            bool loginExitosoPhone = false;
            
            if (usr == "indefinido")
            {
                loginExitosoPhone = UsuarioBL.validarPhone(phone, pwd);
            }
            if(phone == "indefinido")
            {
                loginExitosoUser = UsuarioBL.validarUser(usr, pwd);
            }
            if (loginExitosoUser == true || loginExitosoPhone == true)
            {
                return View("../Home/Index", model);                
            }
            else
            {
                return View("../Usuario/Login", model);
            }

        }
    }
}
