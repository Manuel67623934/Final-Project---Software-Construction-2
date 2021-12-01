using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class ProductoModel
    {
        public ProductoEntidad producto_solo { get; set; }
        public List<CategoriaEntidad> categoria_layout { get; set; }
    }
}
