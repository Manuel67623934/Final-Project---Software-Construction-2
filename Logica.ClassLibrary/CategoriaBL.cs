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
            List<CategoriaBE> listaa;
            lista = data.getCategoria();
            int j = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if(lista[i].Estado == '1')
                {
                    lista [j]= lista[i];
                    j++;
                }

            }
            return lista;
        }
    }
}
