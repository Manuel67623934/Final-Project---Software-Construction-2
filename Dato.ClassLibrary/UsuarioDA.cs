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
        public UsuarioBE GetUsuario()
        {
            return new UsuarioBE { User = "admi", Password = "1234"};
        }
    }
}
