using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class ProductoModel
    {
        public ProductoBE producto_solo { get; set; }
        public List<CategoriaBE> categoria_layout { get; set; }
    }
}
