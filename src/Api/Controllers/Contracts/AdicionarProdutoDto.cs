using ProvaApi.Api.Core.Application.ProductAgg.Contracts;

namespace ProvaApi.Api.Controllers.Contracts
{
    public class AdicionarProdutoDto : IAdicionarProduto
    {
        public string Nome { get; set; }
        public long Preco { get; set; }
    }
}