

using Entidad.ClassLibrary;
using System.Collections.Generic;

namespace Dato.ClassLibrary
{
   public class CategoriaDatos
    {
        // Retorna las categorias.
        public List<CategoriaEntidad> ObtenerCategoria()
        {
            List<CategoriaEntidad> listacategoria = new List<CategoriaEntidad>() { 
            new CategoriaEntidad(){Id =1 , Nombre="Licores",Estado='1',UrlSeo="Licores"},
            new CategoriaEntidad(){Id =2 , Nombre="Cigarros",Estado='1',UrlSeo="Cigarros"},
            new CategoriaEntidad(){Id =3 , Nombre="Cervezas",Estado='1',UrlSeo="Cerveza"},
            new CategoriaEntidad(){Id =4 , Nombre="Snacks",Estado='1',UrlSeo="Snacks"},
            };

            return listacategoria;
        }
    }
}
