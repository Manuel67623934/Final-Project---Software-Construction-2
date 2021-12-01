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
        // Retorna todos los productos desde la capa de Datos.
        public List<ProductoEntidad> ObtenerProductos()
        {
            ProductoDatos dataProductos = new ProductoDatos();
            List<ProductoEntidad> lista;
            List<ProductoEntidad> listaTemporal = new List<ProductoEntidad>();
            lista = dataProductos.ObtenerProducto();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Portada.Equals('1'))
                {
                    listaTemporal.Add(lista[i]);
                }
            }
            return listaTemporal;
        }
        
        // Retorna un producto especifico extraído desde la capa de Datos.
        public ProductoEntidad ObtenerProducto(string urlSeo)
        {
            ProductoDatos dataProductos = new ProductoDatos();
            List<ProductoEntidad> lista;
            ProductoEntidad producto = new ProductoEntidad();
            lista = dataProductos.ObtenerProducto();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].UrlSeo.Equals(urlSeo))
                {
                    producto.Id = lista[i].Id;
                    producto.IdCategoria = lista[i].IdCategoria;
                    producto.Nombre = lista[i].Nombre;
                    producto.Descripcion = lista[i].Descripcion;
                    producto.Precio = lista[i].Precio;
                    producto.Stock = lista[i].Stock;
                    producto.UrlSeo = lista[i].UrlSeo;
                    producto.Imagen = lista[i].Imagen;
                }
            }
            return producto;
        }
        
        // Retorna un producto específico.
        public static ProductoEntidad RetornaProducto(int Id)
        {
            ProductoDatos ProductoDatos = new ProductoDatos();
            ProductoEntidad producto = ProductoDatos.ObtenerProducto().FirstOrDefault(elegirItem => elegirItem.Id == Id);
            return producto;
        }
        
    }
}
