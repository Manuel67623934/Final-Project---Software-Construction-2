using Dato.ClassLibrary;
using Entidad.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.ClassLibrary
{
   public class CategoriaLogica
    {
        // Obtiene las categorias desde la capa de datos.
        public List<CategoriaEntidad> ObtenerCategorias()
        {
            CategoriaDatos data = new CategoriaDatos();
            List<CategoriaEntidad> lista;
            List<CategoriaEntidad> listaTemporal = new List<CategoriaEntidad>();
            lista = data.ObtenerCategoria();
              for (int i = 0; i < lista.Count; i++)
              {
                  if(lista[i].Estado.Equals('1'))
                  {                 
                      listaTemporal.Add(lista[i]);
                  }
              }
            Console.WriteLine(listaTemporal);
            return listaTemporal;
        }

        // Obtiene los productos desde la capa de datos.
        public List<ProductoEntidad> ObtenerProductos(string urlSeo)
        {
            ProductoDatos datoProducto = new ProductoDatos();
            CategoriaDatos datoCategoria = new CategoriaDatos();
            List<CategoriaEntidad> listaCategoria;
            List<ProductoEntidad> listaProducto;
            List<ProductoEntidad> listaTemporal = new List<ProductoEntidad>();
            listaProducto = datoProducto.ObtenerProducto();
            listaCategoria = datoCategoria.ObtenerCategoria();
            int idCategoria = 0;
            for (int i = 0; i < listaCategoria.Count; i++)
            {
                if (listaCategoria[i].UrlSeo.Equals(urlSeo))
                {
                    idCategoria = listaCategoria[i].Id;
                }
            }
            for (int i = 0; i < listaProducto.Count; i++)
            {
                if (listaProducto[i].IdCategoria.Equals(idCategoria))
                {
                    listaTemporal.Add(listaProducto[i]);
                }
            }
            return listaTemporal;
        }

        // Obtiene una categoria especifica.
        public CategoriaEntidad ObtenerCategoria (string urlSeo)
        {
            List<CategoriaEntidad> listaCategoria = new CategoriaDatos().ObtenerCategoria();
            CategoriaEntidad categoriaTemporal = new CategoriaEntidad();
            for (int i = 0; i < listaCategoria.Count; i++)
            {
                if (listaCategoria[i].UrlSeo.Equals(urlSeo))
                {
                    categoriaTemporal = listaCategoria[i];
                }
            }
            return categoriaTemporal;
        }

        // Obtiene la categoria de un producto particular.
        public CategoriaEntidad ObtenerCategoriaProducto (string urlSeo)
        {
            CategoriaEntidad categoria = new CategoriaEntidad();
            List<CategoriaEntidad> listaCategoria = new CategoriaLogica().ObtenerCategorias();
            ProductoEntidad producto = new ProductoBL().ObtenerProducto(urlSeo);
            for (int i = 0; i < listaCategoria.Count; i++)
            {
                if (listaCategoria[i].Id.Equals(producto.IdCategoria))
                {
                    categoria = listaCategoria[i];
                }
            }
            return categoria;
        }
    }
}
