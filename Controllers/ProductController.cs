using Daylon.Padaria.Estoque.Communication;
using Daylon.Padaria.Estoque.Communication.Requests;
using Daylon.Padaria.Estoque.Communication.Responses;
using Microsoft.AspNetCore.Http;
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
            return Created();
        }
    }
}
