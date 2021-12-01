
using System.ComponentModel.DataAnnotations;

namespace Entidad.ClassLibrary
{
   public class CategoriaEntidad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public char Estado { get; set; }
        [Required]
        public string UrlSeo { get; set; }        
    }
}
