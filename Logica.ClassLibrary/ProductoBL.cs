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

        public ProductoBE getProducto(string Url_Seo)
        {
            ProductoDA dato = new ProductoDA();
            List<ProductoBE> lista;
            ProductoBE product = new ProductoBE();
            lista = dato.getProducto();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].UrlSeo.Equals(Url_Seo))
                {
                    product.Id = lista[i].Id;
                    product.id_categoria = lista[i].id_categoria;
                    product.Nombre = lista[i].Nombre;
                    product.Descripcion = lista[i].Descripcion;
                    product.Precio = lista[i].Precio;
                    product.Stock = lista[i].Stock;
                    product.UrlSeo = lista[i].UrlSeo;
                    product.imagen = lista[i].imagen;
                }
            }
            return product;
        }


        public static ProductoBE RetornaProducto(int Id)
        {
            ProductoDA productoDA = new ProductoDA();
            ProductoBE producto = productoDA.getProducto().FirstOrDefault(elegirItem => elegirItem.Id == Id);
            return producto;
        }

    }
}
