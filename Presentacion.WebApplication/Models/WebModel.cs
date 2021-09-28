using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class WebModel
    {
        public ProductoBE producto_solo { get; set; }
        public List<CategoriaBE> categoria_layout { get; set; }
        public List<ProductoBE> prod { get; set; }
        public CategoriaBE categoria { get; set; }
        public string prueba { get; set; }
        public int tipoLogin { get; set; }
        public string tipoLoginNombre { get; set; }

        public int enSession { get; set; }

        public UsuarioBE usuario{ get; set; }

        public int idUsuario { get; set; }
    }
}
