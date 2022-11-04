using System.Collections.Generic;
using ProvaApi.Api.Core.Domain.ProductAgg.Entities;

namespace ProvaApi.Api.Core.Domain.ProductAgg.Repositories
{
    public interface IProdutoRepositorio
    {
        void Adicionar(Produto produto);
        ICollection<Produto> Buscar(string nome);
        Produto ObterPeloId(string id);
    }
}