

using Entidad.ClassLibrary;
using System.Collections.Generic;

namespace Dato.ClassLibrary
{
   public class CategoriaDA
    {
        public CategoriaBE GetCategoria()
        {
            List<CategoriaBE> listacategoria = new List<CategoriaBE>() { 
            new CategoriaBE(){Id =1 , Nombre="Licores",Estado='1',UrlSeo="licores"},
            new CategoriaBE(){Id =2 , Nombre="Cigarros",Estado='1',UrlSeo="cigarros"},
            new CategoriaBE(){Id =3 , Nombre="Cerveza",Estado='0',UrlSeo="cervezs"},
            new CategoriaBE(){Id =4 , Nombre="Snacks",Estado='1',UrlSeo="snacks"},
            };
           
            
        }
    }
}
