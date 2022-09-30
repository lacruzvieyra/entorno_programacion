using System.ComponentModel.DataAnnotations;

namespace ApiDespliegueContenedorAutor.entidades
{
    public class Autor
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:120, ErrorMessage ="El {0} no pude tener mas de{1} caracteres")]
        public string Nombre { get; set; }

        //public List<AutorLibro> AutoresLibros { get; set; }

    }
}
