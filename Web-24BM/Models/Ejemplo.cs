
using System.ComponentModel.DataAnnotations;

namespace Web_24BM.Models
{
    public class Ejemplo
    {
        [Required]
        public string Titulo { get; set; }
        public string Parrafo { get; set; }
    }
}
