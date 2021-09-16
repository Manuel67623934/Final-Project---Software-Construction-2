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
        public UsuarioBE GetAll()
        {
            return new UsuarioBE { User = "José Manuel Bravo Rengifo", Password = "Cliente123", Address = "Jr. Example #456", Reference= "Casa blanca de 2 pisos" };
        }
    }
}
