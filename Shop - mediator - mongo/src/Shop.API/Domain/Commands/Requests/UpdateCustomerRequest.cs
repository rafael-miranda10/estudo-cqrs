using MediatR;
using Shop.API.Domain.Commands.Validations;
using Shop.API.Domain.Common;

namespace Shop.API.Domain.Commands.Requests
{
    public class UpdateCustomerRequest : Command, IRequest<RequestResult>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public UpdateCustomerRequest() { }

        public UpdateCustomerRequest(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void ValidateCommand()
        {
            ValidationResult = new UpdateCustomerValidation().Validate(this);
        }
    }
}
