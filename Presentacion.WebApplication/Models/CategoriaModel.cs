using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class CategoriaModel
    {
        public List<CategoriaBE> cate { get; set; }
        public List<ProductoBE> prod { get; set; }
        public string prueba { get; set; }

        //tipoLogin
        public int Id { get; set; }
        public string tipoLogin { get; set; }


    }
}
