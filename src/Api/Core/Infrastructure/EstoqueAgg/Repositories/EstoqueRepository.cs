using System.Collections.Immutable;
using ProvaApi.Api.Core.Domain.EstoqueAgg.Entities;
using ProvaApi.Api.Core.Domain.EstoqueAgg.Repositories;
using ProvaApi.Api.Core.Infrastructure.Shared;

namespace ProvaApi.Api.Core.Infrastructure.EstoqueAgg.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly PedidoDbContext _context;

        public EstoqueRepository(PedidoDbContext context)
        {
            _context = context;
        }
        public Estoque Carregar()
        {
            var itens = _context.EstoqueItens.ToImmutableList();
            return new Estoque(itens);
        }

        public void Adicionar(EstoqueItem estoqueItem)
        {
            _context.EstoqueItens.Add(estoqueItem);
        }
    }
}