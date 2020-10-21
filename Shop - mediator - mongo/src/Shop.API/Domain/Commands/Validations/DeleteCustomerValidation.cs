using FluentValidation;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Common.Resources;

namespace Shop.API.Domain.Commands.Validations
{
    public class DeleteCustomerValidation : AbstractValidator<DeleteCustomerRequest>
    {
        public DeleteCustomerValidation()
        {
            RuleFor(x => x.Id)
               .NotNull()
               .NotEmpty()
               .WithMessage(Resource.IdCustomerInvalid);
        }
    }
}
