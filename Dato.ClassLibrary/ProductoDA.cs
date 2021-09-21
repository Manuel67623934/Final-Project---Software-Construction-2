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
                new ProductoBE(){Id=0, Nombre="Cerveza Cusqueña",UrlSeo ="Cerveza_Cusqueña", Stock=12,Descripcion="Cerveza Cusqueña 180ml",portada='1', Precio=4.0},
                new ProductoBE(){Id=1, Nombre="Cerveza Pilsen",UrlSeo ="Cerveza_Pilsen", Stock=22,Descripcion="Cerveza Pilsen 180ml",portada='1' ,Precio=4.5},
                new ProductoBE(){Id=2, Nombre="Cigarro Lucky Strike",UrlSeo ="Cigarro_Lucky_strike", Stock=25,Descripcion="Cigarro Lucky Strike 20 unidades",portada='1' ,Precio=22},
                new ProductoBE(){Id=4, Nombre="Cigarro Hamilton",UrlSeo ="Cigarro_Hamilton", Stock=28,Descripcion="Cigarro Hamilton 20 unidades",portada='0', Precio=18},
                new ProductoBE(){Id=5, Nombre="Cigarro Pall Mall",UrlSeo ="Cigarro_Pall_Mall", Stock=32,Descripcion="Cigarro Pall Mall 20ml",portada='1', Precio=17.5}
            };
            return listaProductos; 
        }
    }
}
