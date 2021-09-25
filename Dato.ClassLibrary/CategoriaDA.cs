

using Entidad.ClassLibrary;
using System.Collections.Generic;

namespace Dato.ClassLibrary
{
   public class CategoriaDA
    {
        public List<CategoriaBE> getCategoria()
        {
            List<CategoriaBE> listacategoria = new List<CategoriaBE>() { 
            new CategoriaBE(){Id =1 , Nombre="Licores",Estado='1',UrlSeo="Licores"},
            new CategoriaBE(){Id =2 , Nombre="Cigarros",Estado='1',UrlSeo="Cigarros"},
            new CategoriaBE(){Id =3 , Nombre="Cerveza",Estado='0',UrlSeo="Cerveza"},
            new CategoriaBE(){Id =4 , Nombre="Snacks",Estado='1',UrlSeo="Snacks"},
            };

            return listacategoria;
        }
    }
}
