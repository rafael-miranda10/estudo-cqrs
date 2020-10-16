using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;
using Shop.API.Domain.Handlers.Interfaces;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {

        }

        [HttpPost]
        [Route("create")]
        public CreateCustomerResponse Create(
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
            )
        {
            return handler.Handle(command);
        }
    }
}
