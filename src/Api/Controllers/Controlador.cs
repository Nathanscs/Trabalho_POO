using Microsoft.AspNetCore.Mvc;
using POO.Api.Core.Application.ProductAgg.AppServices;
using POO.Api.Controllers.Contracts;
using POO.Api.Controllers.Extensions;
using System.Net;
namespace POO.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PController : ControllerBase
    {
        private readonly PAppService _appService;
    public PController(PAppService appService)
    {
     _appService = appService;
    }
    [HttpPost]
        public IActionResult Add(AddPDto AddProdutoDto)
        {
            var P = _appService.Add(AddProdutoDto);
    return P.AsResponse(HttpStatusCode.Created);
        }
        [HttpGet]
        public IActionResult Query(string nome)
        {var PP = _appService.Buscar(nome);
        return PP.AsResponse(HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var P = _appService.ObterPeloId(id);
            return P.AsResponse(HttpStatusCode.OK);
        }
        [HttpPut("{id}")]
        public IActionResult att(string id, attProdutoDto attProduto)
        {
        var P = _appService.att(id, attProduto);
            return P.AsResponse(HttpStatusCode.OK);
        }
        [HttpDelete("{id}")]
        public IActionResult Apagar(string id)
    {
    _appService.Apagar(id);
    return NoContent();
}
}
}
