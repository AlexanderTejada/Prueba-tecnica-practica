using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica.Modelos;

namespace Prueba_Tecnica.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id =1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la villa..",
                    ImageUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Tarifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                   new Villa()
                   {
                       Id = 2,
                       Nombre = "Premium Vista a la Piscina",
                       Detalle = "Detalle de la villa.",
                       ImageUrl = "",
                       Ocupantes = 4,
                       MetrosCuadrados = 40,
                       Tarifa = 150,
                       Amenidad = "",
                       FechaCreacion = DateTime.Now,
                       FechaActualizacion = DateTime.Now
                   }

            );        
        }

    }
}
