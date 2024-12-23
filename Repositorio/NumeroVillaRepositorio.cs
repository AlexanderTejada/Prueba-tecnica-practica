using Prueba_Tecnica.Repositorio.IRepositorio;
using Prueba_Tecnica.Modelos;
using Prueba_Tecnica.Datos;

namespace Prueba_Tecnica.Repositorio
{
    public class VillaRepositorio :Repositorio<Villa>, IVillaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public VillaRepositorio(ApplicationDbContext db) :base(db) 
        {
            _db =db;
        }
        public async Task <Villa> Actualizar (Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.Villas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
