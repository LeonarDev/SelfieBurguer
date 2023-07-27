using SelfieBurguer.DataTransfer.Compra;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCompra
    {
        void Add(CompraRequest obj);
        void Update(CompraRequest obj);
        void Delete(CompraRequest obj);
        IEnumerable<CompraResponse> GetAll();
        CompraResponse GetById(int id);
    }
}