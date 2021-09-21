using Dato.ClassLibrary;
using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ClassLibrary
{
   public class ProductoBL
    {
        public List<ProductoBE> GetProductos()
        {
            ProductoDA DatoProducto= new ProductoDA();
            List<ProductoBE> lista;
            List<ProductoBE> lista_temp = new List<ProductoBE>();
            lista = DatoProducto.getProducto();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].portada.Equals('1'))
                {

                    lista_temp.Add(lista[i]);

                }

            }
            return lista_temp;
        }
    }
}
