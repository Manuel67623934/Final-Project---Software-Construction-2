using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad.ClassLibrary;

namespace Presentacion.WebApplication.Models
{
    public class UsuarioModel
    {
        public List<UsuarioBE> usuarioModel { get; set;}
        public UsuarioBE usuarioLogeado { get; set; }
    }
}
