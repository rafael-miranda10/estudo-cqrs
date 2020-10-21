using MediatR;
using Shop.API.Domain.Commands.Validations;
using Shop.API.Domain.Common;

namespace Shop.API.Domain.Commands.Requests
{
    public class DeleteCustomerRequest : Command, IRequest<RequestResult>
    {
        public string Id { get; set; }

        public DeleteCustomerRequest() { }

        public DeleteCustomerRequest(string id)
        {
            Id = id;
        }

        public void ValidateCommand()
        {
            ValidationResult = new DeleteCustomerValidation().Validate(this);
        }
    }
}
