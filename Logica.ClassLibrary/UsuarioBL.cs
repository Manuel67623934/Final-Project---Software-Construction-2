using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;
using Dato.ClassLibrary;
using Microsoft.AspNetCore.Http;

namespace Logica.ClassLibrary
{
    public class UsuarioLogica
    {
        // Inicializar valores (id).
        static int _nextId = 4;
        
        // Retorna todos los usuarios de la base de datos.
        public List<UsuarioEntidad> ObtenerUsuarios()
        {            
            return UsuarioDatos.ObtenerTodo();
        }

        // Retorna el Id de un usuario especifico mediante la compación del username y validando el número de celular.
        public static int ObtenerId(string usr, string phone)
        {            
            UsuarioEntidad usuario = UsuarioDatos.ObtenerTodo().FirstOrDefault(elegirUsuario => elegirUsuario.Usuario == usr);
            if (usuario == null)
            {
                UsuarioEntidad usuario1 = UsuarioDatos.ObtenerTodo().FirstOrDefault(elegirUsuario => elegirUsuario.NumeroCelular == phone);
                return usuario1.Id;
            }
            else
            {
                return usuario.Id;
            }            
        }

        // Retorna un usuario especifico.
        public static UsuarioEntidad ObtenerUnicoUsuario(int id)
        {
            UsuarioEntidad usuarioRecuperar = UsuarioDatos.ObtenerUnicoUsuario(id);
            return usuarioRecuperar;
        }

        // Registra nuevos usuarios en la data.
        public static void AgregarUsuarios(UsuarioEntidad usuario)
        {
            usuario.Id = _nextId++;
            UsuarioDatos.Agregar(usuario);        
        }

        // Eliminar un usuario mediante la identificación del su id.
        public static void EliminarUsuario(int id)
        {                  
            UsuarioEntidad usuarioEliminar = UsuarioDatos.ObtenerTodo().FirstOrDefault(elegirUsuario => elegirUsuario.Id == id);
            UsuarioDatos.Eliminar(usuarioEliminar);
        }

        // Válida el username ingresado por el usuario.
        internal static bool ValidarUsuario(string usr, string pwd )
        {
            UsuarioEntidad userValidar = UsuarioDatos.ObtenerTodo().FirstOrDefault(elegirUsuario => elegirUsuario.Usuario == usr);
            if (userValidar == null)
            {
                return false;
            }
            else
            {
                if (userValidar.Contraseña == pwd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Válida el celular ingresado por el usuario.
        public static bool ValidarCelular(string phone, string pwd)
        {            
            UsuarioEntidad phoneValidar = UsuarioDatos.ObtenerTodo().FirstOrDefault(elegirUsuario => elegirUsuario.NumeroCelular == phone);
            if (phoneValidar == null)
            {
                return false;
            }
            else
            {
                if (phoneValidar.Contraseña == pwd)
                {                    
                    return true;                    
                }
                else
                {
                    return false;
                }
            }
        }

        // Válida la identidad del usuario para permitir o denegar el acceso a las credenciales.
        public static int LoginCorrecto(string usr, string phone , string pwd)
        {              
            bool loginExitosoUser = false;
            bool loginExitosoPhone = false;
            if (usr == "indefinido")
            {
                loginExitosoPhone = UsuarioLogica.ValidarCelular(phone, pwd);
            }
            if (phone == "indefinido")
            {
                loginExitosoUser = UsuarioLogica.ValidarUsuario(usr, pwd);
            }
            if (loginExitosoUser || loginExitosoPhone)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
