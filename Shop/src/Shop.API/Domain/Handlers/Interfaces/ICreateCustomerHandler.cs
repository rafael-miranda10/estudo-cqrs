using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;

namespace Shop.API.Domain.Handlers.Interfaces
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}
