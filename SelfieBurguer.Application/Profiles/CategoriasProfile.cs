using AutoMapper;
using SelfieBurguer.DataTransfer.Categoria;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class CategoriasProfile : Profile
    {
        public CategoriasProfile()
        {
            CategoriaMap();
        }

        private void CategoriaMap()
        {
            CreateMap<Categoria, CategoriaResponse>();
            CreateMap<IEnumerable<Categoria>, IEnumerable<CategoriaResponse>>();
        }
    }
}