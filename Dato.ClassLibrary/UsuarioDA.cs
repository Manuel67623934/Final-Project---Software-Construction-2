using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
    public class UsuarioDA
    {
        
        static List<UsuarioBE> ListaUsuarios { get; }
        //static int nextId = 4;
        
        
        static UsuarioDA()
        {
            //UsuarioBE user = new UsuarioBE();

            ListaUsuarios = new List<UsuarioBE>
            {
                new UsuarioBE {Id=1, User = "cliente@cs2.com", Password = "cliente123", FirtsName="NombreCliente" , LastsName="ApellidoCliente", NumberPhone="987564234",Address = "Jr. Example #456", Reference= "Casa blanca de 2 pisos" },
                new UsuarioBE {Id=2, User = "bravo@cs2.com", Password = "bravo123", FirtsName="Manuel" , LastsName="Bravo", NumberPhone="987564794",Address = "Jr. Pinos #456", Reference= "Frente al Poder Judicial" },
                new UsuarioBE {Id=3, User = "taniguchi@cs2.com", Password = "taniguchi123", FirtsName="Sonny" , LastsName="Taniguchi", NumberPhone="987564213",Address = "Jr. San Mateo #456", Reference= "Al lado de Comercial R&R" }
            };           
        }

        public static List<UsuarioBE> GetAll()
        {
            return ListaUsuarios;
        }

        public static void Add(UsuarioBE usuario)
        {
            //usuario.Id = nextId++;
            ListaUsuarios.Add(usuario);
        }

        public static void Delete(UsuarioBE usuarioEliminar)
        {
            ListaUsuarios.Remove(usuarioEliminar);
        }

    }
}
