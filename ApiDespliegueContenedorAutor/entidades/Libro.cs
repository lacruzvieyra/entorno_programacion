namespace ApiDespliegueContenedorAutor.entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
    }
}
