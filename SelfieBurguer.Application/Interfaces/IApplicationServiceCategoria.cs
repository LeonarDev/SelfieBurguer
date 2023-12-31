﻿using SelfieBurguer.DataTransfer.Categoria;

namespace SelfieBurguer.Application.Interfaces
{
    public interface IApplicationServiceCategoria
    {
        void Add(CategoriaRequest obj);
        void Update(CategoriaRequest obj);
        void Delete(CategoriaRequest obj);
        IEnumerable<CategoriaResponse> RecuperarTodos();
        CategoriaResponse RecuperarPorId(int id);
    }
}