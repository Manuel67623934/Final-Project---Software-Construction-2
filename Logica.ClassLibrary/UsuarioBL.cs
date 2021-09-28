using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;
using Dato.ClassLibrary;

namespace Logica.ClassLibrary
{
    public class UsuarioBL
    {
        static int nextId = 4;
        public List<UsuarioBE> getUsuarios()
        {
            List<UsuarioBE> dataUsuarios;
            return dataUsuarios = UsuarioDA.GetAll();
        }


        public static int GetId(string usr)
        {
            int userId = 0;
            UsuarioBE usuario = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.User == usr);
            return userId = usuario.Id;
        }


        public static UsuarioBE GetUserUnic(int id)
        {
            UsuarioBE usuarioRecuperar = UsuarioDA.GetUserUnic(id);
            return usuarioRecuperar;
        }


        public static void addUsuarios(UsuarioBE usuario)
        {
            usuario.Id = nextId++;
            UsuarioDA.Add(usuario);        
        }

        public static void deleteUsuario(int id)
        {                  
            UsuarioBE usuarioEliminar = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.Id == id);
            UsuarioDA.Delete(usuarioEliminar);
        }

        public static bool validarUser(string usr, string pwd )
        {
                bool validacionCorrecta = false;
                UsuarioBE userValidar = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.User == usr);
                if (userValidar== null)
                {
                    return validacionCorrecta;
                }
                else
                {
                    if (userValidar.Password == pwd)
                    {
                        
                        return validacionCorrecta = true;
                    }
                    else
                    {
                        return validacionCorrecta;
                    }
                }

            
            
        }


        public static bool validarPhone(string phone, string pwd)
        {
            bool validacionCorrecta = false;
            UsuarioBE phoneValidar = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.User == phone);

            if (phoneValidar == null)
            {
                return validacionCorrecta;
            }
            else
            {
                if (phoneValidar.Password == pwd)
                {
                    
                    return validacionCorrecta = true;                    
                }
                else
                {
                    return validacionCorrecta;
                }
            }


        }


        public static int loginCorrecto(string usr, string phone , string pwd)
        {
            int loginCorrecto = 0;
            

            bool loginExitosoUser = false;
            bool loginExitosoPhone = false;

            if (usr == "indefinido")
            {
                loginExitosoPhone = UsuarioBL.validarPhone(phone, pwd);
            }
            if (phone == "indefinido")
            {
                loginExitosoUser = UsuarioBL.validarUser(usr, pwd);
            }
            if (loginExitosoUser == true || loginExitosoPhone == true)
            {
                return loginCorrecto = 1;
            }
            else
            {
                return loginCorrecto;
            }


        }

        
        
        public static void abrirSesion(int id)
        {
            UsuarioBE usuario = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.Id == id);
            usuario.Session = 1;
            UsuarioDA.Update(usuario);
        }
        
        public static void cerrarSession(int id)
        {
            UsuarioBE usuario = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.Id == id);
            usuario.Session = 0;
            UsuarioDA.Update(usuario);
        }


        public static int verificarSession(int id)
        {
            int session = 0;
            UsuarioBE user = UsuarioDA.GetUserUnic(id);
            if (user.Session == 1)
            {
                return session = 1;
            }
            else
            {
                return session;
            }
        }


        public static UsuarioBE BuscarUsuarioSessionActiva()
        {
            UsuarioBE usuarioEnSession= new UsuarioBE();
            foreach (var item in UsuarioDA.GetAll())
            {
                if (item.Id==1)
                {
                    usuarioEnSession = item;                    
                    break;
                }
                else
                {
                    usuarioEnSession = UsuarioDA.GetUserUnic(0);
                    break;
                }
            }
            return usuarioEnSession;
        }
        

       
    }
}
