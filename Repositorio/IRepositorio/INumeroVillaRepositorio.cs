using Prueba_Tecnica.Modelos;

namespace Prueba_Tecnica.Repositorio.IRepositorio
{
    public interface INumeroVillaRepositorio :IRepositorio<NumeroVilla>
    {
        Task  <NumeroVilla> Actualizar(NumeroVilla entidad);
    }
}
