using Daylon.Padaria.Estoque.Application.UseCases.Product.Register;
using Daylon.Padaria.Estoque.Communication.Requests;
using Daylon.Padaria.Estoque.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Daylon.Padaria.Estoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisteredProductJson), StatusCodes.Status201Created)]
        public IActionResult Register(RequestRegisterProductJson request)
        {
            var useCase = new RegisterProductUseCase();

            var result = useCase.Execute(request);

            return Created(string.Empty, result);
        }
    }
}
