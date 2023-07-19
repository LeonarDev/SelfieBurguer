using SelfieBurguer.Application.Dtos.Compra;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCompra
    {
        void Add(CompraDto obj);
        void Update(CompraDto obj);
        void Delete(CompraDto obj);
        IEnumerable<CompraDto> GetAll();
        CompraDto GetById(int id);
    }
}
