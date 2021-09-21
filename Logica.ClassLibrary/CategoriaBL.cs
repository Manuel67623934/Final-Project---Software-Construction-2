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
    }
}
