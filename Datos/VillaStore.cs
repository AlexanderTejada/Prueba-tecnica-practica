using Prueba_Tecnica.Modelos.Dto;

namespace Prueba_Tecnica.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList= new List<VillaDto>
        {
            new VillaDto{Id=1, Nombre="Vista a la piscina", Ocupantes=3, MetrosCuadrados=50},
            new VillaDto{Id=2, Nombre="Vista a la plasha", Ocupantes=4, MetrosCuadrados=80}

        };
    }
}
