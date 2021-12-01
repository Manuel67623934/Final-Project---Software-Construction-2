using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class CategoriaModel
    {
        public List<CategoriaEntidad> categoria_layout { get; set; }
        public List<ProductoEntidad> prod { get; set; }
        public CategoriaEntidad categoria { get; set; }
        public string prueba { get; set; }

        //tipoLogin
        public int Id { get; set; }
        public string tipoLogin { get; set; }


    }
}
