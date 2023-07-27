using AutoMapper;
using SelfieBurguer.DataTransfer.Compra;
using SelfieBurguer.Domain.Entities;

namespace SelfieBurguer.Application.Profiles
{
    public class ComprasProfile : Profile
    {
        public ComprasProfile()
        {
            CompraMap();
        }

        private void CompraMap()
        {
            CreateMap<Compra, CompraResponse>();
            CreateMap<IEnumerable<Compra>, IEnumerable<CompraResponse>>();
        }
    }
}