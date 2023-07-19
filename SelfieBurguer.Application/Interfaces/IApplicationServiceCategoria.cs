using SelfieBurguer.Application.Dtos.Categoria;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCategoria
    {
        void Add(CategoriaDto obj);
        void Update(CategoriaDto obj);
        void Delete(CategoriaDto obj);
        IEnumerable<CategoriaDto> GetAll();
        CategoriaDto GetById(int id);
    }
}
