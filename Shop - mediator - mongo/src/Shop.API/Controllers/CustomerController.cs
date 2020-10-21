using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;
using Shop.API.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult> Create(
            [FromServices] IMediator mediator,
            [FromBody] CreateCustomerRequest command
            )
        {
            var result = await mediator.Send(command);
            if (result.HasNotifications())
                return BadRequest(result.Notifications.Select(x => x));

            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult> Update(
            [FromServices] IMediator mediator,
            [FromBody] UpdateCustomerRequest command
            )
        {
            var result = await mediator.Send(command);
            if (result.HasNotifications())
                return BadRequest(result.Notifications.Select(x => x));

            return Ok();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> Delete(
            [FromServices] IMediator mediator,
            [FromBody] DeleteCustomerRequest command
            )
        {
            var result = await mediator.Send(command);
            if (result.HasNotifications())
                return BadRequest(result.Notifications.Select(x => x));

            return Ok();
        }

        [HttpGet]
        [Route("all-customers")]
        public async Task<ActionResult<List<CreateCustomerResponse>>> GetAll(
            [FromServices] ICustomerRepository customerRepository,
            [FromServices] IMapper mapper)
        {
            var customers = await customerRepository.GetCustomers();
            var customerResponse = mapper.Map<List<CreateCustomerResponse>>(customers);
            return customerResponse;
        }

        [HttpGet]
        [Route("customerById")]
        public async Task<ActionResult<CreateCustomerResponse>> GetById(
            [FromServices] ICustomerRepository customerRepository,
            [FromServices] IMapper mapper,
            [FromQuery] string id)
        {
            var customers = await customerRepository.GetCustomer(id);
            var customerResponse = mapper.Map<CreateCustomerResponse>(customers);
            return customerResponse;
        }

        [HttpGet]
        [Route("customerByName")]
        public async Task<ActionResult<CreateCustomerResponse>> GetByName(
           [FromServices] ICustomerRepository customerRepository,
           [FromServices] IMapper mapper,
           [FromQuery] string name)
        {
            var customers = await customerRepository.GetCustomerByName(name);
            var customerResponse = mapper.Map<CreateCustomerResponse>(customers);
            return customerResponse;
        }



    }
}
