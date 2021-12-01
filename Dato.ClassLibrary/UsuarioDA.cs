using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
    public class UsuarioDatos 
    {        
        static List<UsuarioEntidad> _listaUsuarios { get; }       
        
        // Crea la lista de usuarios.
        static UsuarioDatos()
        {
           _listaUsuarios = new List<UsuarioEntidad>
            {
                new UsuarioEntidad {Id=0, Usuario = "cliente@cs2.com", Contraseña = "cliente123", Nombres="NombreCliente" , Apellido="ApellidoCliente", NumeroCelular="987564231",Direccion = "Jr. Example #456", Referencia= "Casa blanca de 2 pisos", EstadoSesion = 1 },
                new UsuarioEntidad {Id=2, Usuario = "bravo@cs2.com", Contraseña = "bravo123", Nombres="Manuel" , Apellido="Bravo", NumeroCelular="987564792",Direccion = "Jr. Pinos #456", Referencia= "Frente al Poder Judicial",  EstadoSesion = 0 },
                new UsuarioEntidad {Id=3, Usuario = "taniguchi@cs2.com", Contraseña = "taniguchi123", Nombres="Sonny" , Apellido="Taniguchi", NumeroCelular="987564213",Direccion = "Jr. San Mateo #456", Referencia= "Al lado de Comercial R&R",  EstadoSesion = 0 }
            };           
        }
        // Retorna toda la lista de usuarios. 
        public static List<UsuarioEntidad> ObtenerTodo()
        {
            return _listaUsuarios;
        }

        // Retornar un usuario específico.
        public static UsuarioEntidad ObtenerUnicoUsuario(int id)
        {
            UsuarioEntidad usuarioRecuperar = _listaUsuarios.FirstOrDefault(elegirUsuario => elegirUsuario.Id == id);
            return usuarioRecuperar;
        }

        // Agrega un nuevo usuario a la lista.
        public static void Agregar(UsuarioEntidad usuario)
        {            
            _listaUsuarios.Add(usuario);
        }

        // Eliminar un usuario de la Lista.
        public static void Eliminar(UsuarioEntidad usuarioEliminar)
        {
            _listaUsuarios.Remove(usuarioEliminar);
        }

        // Actualizar un usuario de la Lista.
        public static void Actualizar(UsuarioEntidad user)
        {
            var index = _listaUsuarios.FindIndex(p => p.Id == user.Id);
            if (index == -1)
                return;
            _listaUsuarios[index] = user;
        }
    }
}
