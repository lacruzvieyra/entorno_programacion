using System.ComponentModel.DataAnnotations;

namespace ApiDespliegueContenedorAutor.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 120, ErrorMessage = "El {0} no puede tener mas de {1} caracteres")]
        public string Nombre { get; set; }
    }
}
