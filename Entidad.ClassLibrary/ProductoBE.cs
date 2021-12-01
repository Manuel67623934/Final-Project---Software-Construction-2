using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad.ClassLibrary
{
   public class ProductoEntidad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [ForeignKey("CategoriaDA")]
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string UrlSeo { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public char Portada { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public string Imagen { get; set; }

    }
}
