﻿using ProvaApi.Api.Core.Domain.EstoqueAgg.Entities;

namespace ProvaApi.Api.Core.Domain.EstoqueAgg.Repositories
{
    public interface IEstoqueRepository
    {
        void Adicionar(EstoqueItem estoqueItem);
        Estoque Carregar();
    }
}