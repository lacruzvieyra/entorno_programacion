using ApiDespliegueContenedorAutor.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApiDespliegueContenedorAutor
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            try
            {
                var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if(databaseCreator != null)
                {
                    if (!databaseCreator.CanConnect()) databaseCreator.Create();
                    if (databaseCreator.HasTables()) databaseCreator.CreateTables();
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //protected override  void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<AutorLibro>()
        //        .HasKey(al => new { al.AutorId, al.LibroId });
        //}
        public DbSet<Autor> Autores { get; set; }
        //public DbSet<Libro> Libros { get; set; }
        //public DbSet<AutorLibro> AutoresLibros { get; set; }
    }
}
