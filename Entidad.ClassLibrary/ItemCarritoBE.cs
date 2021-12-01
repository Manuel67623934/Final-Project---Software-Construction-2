using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidad.ClassLibrary
{
    public class ItemCarritoEntidad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public ProductoEntidad Producto { get; set; }
        [Required]
        public string ProductoNombre { get; set; }
        [Required]
        public double ProductoPrecio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Subtotal { get; set; }
        [Required]
        public double Total { get; set; }
    }
}
