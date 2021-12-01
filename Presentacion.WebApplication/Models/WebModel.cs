using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentacion.WebApplication.Models
{
    public class WebModel
    {
        public ProductoEntidad producto_solo { get; set; }
        public List<CategoriaEntidad> categoria_layout { get; set; }
        public List<ProductoEntidad> prod { get; set; }
        public CategoriaEntidad categoria { get; set; }
        public string prueba { get; set; }
        public int tipoLogin { get; set; }
        public string tipoLoginNombre { get; set; }

        public int enSession { get; set; }
        public string Estado_Session { get; set; }
        public int Usuario_en_Session { get; set; }
        public UsuarioEntidad usuario{ get; set; }

        public int idUsuario { get; set; }
        public int loginCorrecto { get; set; }



        public List<ItemCarritoEntidad> ItemsCarrito { get; set; }
        public double MontoTotalCarrito { get; set; }
    }
}
