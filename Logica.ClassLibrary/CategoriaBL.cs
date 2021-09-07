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
        public List<CategoriaBE> getCategoria()
        {
            CategoriaDA data = new CategoriaDA();
            List<CategoriaBE> lista;
            lista = data.getCategoria();
            var FiltrarCategoria = lista.Where(lista.)
            lista.Where();

            return lista;
        }
    }
}
