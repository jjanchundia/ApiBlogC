using BlogC.Data.Mapping;
using BlogC.Data.Models;
using Microsoft.EntityFrameworkCore;
using BlogC.Data.Seed;

namespace BlogC.Data
{
    public class NoticiasContext:DbContext
    {
        public DbSet<NoticiasModels> Noticias { get; set; }
        public DbSet<UsuarioModels> Usuario { get; set; }
        //Configuramos DBContext
        public NoticiasContext(DbContextOptions<NoticiasContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //Lanzamos nuestra configuración
            modelBuilder.ApplyConfiguration(new NoticiasMap());
            //Busca todos los DbSet o todos los mapping
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            //modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}
