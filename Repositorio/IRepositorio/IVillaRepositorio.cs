using Prueba_Tecnica.Modelos;

namespace Prueba_Tecnica.Repositorio.IRepositorio
{
    public interface IVillaRepositorio :IRepositorio<Villa>
    {
        Task  <Villa> Actualizar(Villa entidad);
    }
}
