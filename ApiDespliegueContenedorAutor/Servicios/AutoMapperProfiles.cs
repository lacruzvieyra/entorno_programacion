using ApiDespliegueContenedorAutor.DTOs;
using ApiDespliegueContenedorAutor.entidades;
using AutoMapper;

namespace ApiDespliegueContenedorAutor.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AutorCreacionDTO, Autor>();
            CreateMap<Autor, AutorDTO>();
        }
    }
}
