using ProvaApi.Api.Core.Application.ProductAgg.Contracts;
using ProvaApi.Api.Core.Domain.ProductAgg.Entities;

namespace ProvaApi.Api.Core.Application.ProductAgg.Parsers
{
    public interface IParser<TFrom, TTo>
    {
        TTo Parse(TFrom from);
    }

    public interface IProdutoParseFactory
    {
        IParser<Produto, IProdutoView> GetProdutoParse();
        IParser<Produto, IProdutoView> GetProdutoReportParse();
    }
}