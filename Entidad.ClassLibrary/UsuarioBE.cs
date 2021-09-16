using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad.ClassLibrary
{
    public class UsuarioBE
    {
        [Key]
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Reference { get; set; }
    }
}
