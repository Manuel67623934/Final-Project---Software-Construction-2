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



    }
}
