using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.ClassLibrary
{
    public class UsuarioEntidad
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string NumeroCelular { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Referencia { get; set; }
        public int EstadoSesion { get; set; }
    }
}
