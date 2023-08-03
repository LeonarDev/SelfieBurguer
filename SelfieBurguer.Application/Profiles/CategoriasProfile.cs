using AutoMapper;
using SelfieBurguer.DataTransfer.Categoria;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class CategoriasProfile : Profile
    {
        public CategoriasProfile()
        {
            CreateMap<Categoria, CategoriaResponse>();
        }
    }
}