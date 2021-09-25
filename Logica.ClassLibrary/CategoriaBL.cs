using Dato.ClassLibrary;
using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Logica.ClassLibrary
{
   public class CategoriaBL
    {
        public List<CategoriaBE> getCategorias()
        {
            CategoriaDA data = new CategoriaDA();
            List<CategoriaBE> lista ;
           List<CategoriaBE> lista_temp = new List<CategoriaBE> ();
            lista = data.getCategoria();
              for (int i = 0; i < lista.Count; i++)
              {
                  if(lista[i].Estado.Equals('1'))
                  {
                 
                      lista_temp.Add(lista[i]);

                  }

              }
            Console.WriteLine(lista_temp);
            return lista_temp;
        }
        public List<ProductoBE> GetProductos(string url_seo)
        {
            ProductoDA dato_producto = new ProductoDA();
            CategoriaDA dato_categoria = new CategoriaDA();
            List<CategoriaBE> lista_categoria;
            List<ProductoBE> lista_producto;
            List<ProductoBE> lista_temp = new List<ProductoBE>();
            lista_producto = dato_producto.getProducto();
            lista_categoria = dato_categoria.getCategoria();
            int id_categoria = 0;
            for (int i = 0; i < lista_categoria.Count; i++)
            {
                if (lista_categoria[i].UrlSeo.Equals(url_seo))
                {
                    id_categoria = lista_categoria[i].Id;
                }
            }
            for (int i = 0; i < lista_producto.Count; i++)
            {
                if (lista_producto[i].id_categoria.Equals(id_categoria))
                {
                    lista_temp.Add(lista_producto[i]);
                }
            }

            return lista_temp;
        }
    }
}
