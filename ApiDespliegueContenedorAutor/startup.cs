namespace ApiDespliegueContenedorAutor
{
    public class startup
    {
        public startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
    }
}
