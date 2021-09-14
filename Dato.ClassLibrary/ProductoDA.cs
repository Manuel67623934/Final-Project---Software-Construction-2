using System.Collections.Generic;
using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
   public class ProductoDA
    {
        public List<ProductoBE> getProducto()
        {
            List<ProductoBE> listaProductos = new List<ProductoBE>
            {
                new ProductoBE(){Id=0, Nombre="prueba 2L", Precio=0.0},
                new ProductoBE(){Id=1, Nombre="Wiski2 1L", Precio=50.2},
                new ProductoBE(){Id=2, Nombre="Wiski3 1L", Precio=50.3},
                new ProductoBE(){Id=3, Nombre="Wiski4 1L", Precio=50.4}
            };
            return listaProductos; 
        }
    }
}
