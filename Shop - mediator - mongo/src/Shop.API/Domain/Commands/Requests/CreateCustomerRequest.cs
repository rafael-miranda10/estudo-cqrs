using MediatR;
using Shop.API.Domain.Commands.Validations;
using Shop.API.Domain.Common;

namespace Shop.API.Domain.Commands.Requests
{
    public class CreateCustomerRequest : Command, IRequest<RequestResult>
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public CreateCustomerRequest() {}

        public CreateCustomerRequest(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void ValidateCommand()
        {
            ValidationResult = new CustomerValidation().Validate(this);
        }
    }
}
