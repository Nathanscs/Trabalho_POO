using ProvaApi.Api.Core.Application.ProductAgg.Contracts;

namespace ProvaApi.Api.Controllers.Contracts
{
    public class AtualizarProdutoDto : IAtualizarProduto
    {
        public string Nome { get; set; }
        public long Preco { get; set; }
    }
}