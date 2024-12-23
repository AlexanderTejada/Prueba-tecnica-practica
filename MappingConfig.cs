using AutoMapper;
using Prueba_Tecnica.Modelos;
using Prueba_Tecnica.Modelos.Dto;

namespace Prueba_Tecnica
{
public class MappingConfig : Profile
    {
       public MappingConfig() 
        { 
         CreateMap<Villa, VillaDto>();
            CreateMap<VillaDto, Villa>();
                CreateMap<Villa, VillaCreateDto>().ReverseMap();
                CreateMap<Villa, VillaUpdateDto>().ReverseMap();
        }
    }
}
