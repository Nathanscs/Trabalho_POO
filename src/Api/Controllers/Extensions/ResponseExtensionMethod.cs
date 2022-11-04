using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProvaApi.Api.Controllers.Contracts;

namespace ProvaApi.Api.Controllers.Extensions
{
    public static class ResponseExtensionMethod
    {
        public static IActionResult AsResponse(this object data, HttpStatusCode statusCode)
        {
            return new ObjectResult(new ResponseDto(data))
            {
                StatusCode = (int) statusCode
            };
        }
    }
}