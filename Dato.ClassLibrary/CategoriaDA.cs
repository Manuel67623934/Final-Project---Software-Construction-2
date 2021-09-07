

using Entidad.ClassLibrary;

namespace Dato.ClassLibrary
{
   public class CategoriaDA
    {
        public CategoriaBE GetCategoria()
        {
            return new CategoriaBE { Id = 1, Nombre = "Licores", Estado = '1', UrlSeo = "Licores" };
        }
    }
}
