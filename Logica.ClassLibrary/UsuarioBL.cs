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

        public static Boolean validarUsuarioWithUser(string usr, string pwd )
        {
                        
            try
            {
                UsuarioBE usuarioValidar = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.User == usr);
                if (usuarioValidar.Password == pwd)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                UsuarioBE usuarioValidar = UsuarioDA.GetAll().FirstOrDefault(elegirUsuario => elegirUsuario.NumberPhone == usr);
                if (usuarioValidar.Password == pwd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        } 
    }
}
