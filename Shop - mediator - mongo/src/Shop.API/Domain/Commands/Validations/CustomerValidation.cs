using FluentValidation;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Common.Resources;

namespace Shop.API.Domain.Commands.Validations
{
    public class CustomerValidation : AbstractValidator<CreateCustomerRequest>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(Constante.Cem)
                .WithMessage(Resource.NameCustomerInvalid);

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress()
                .WithMessage(Resource.EmailCustomerInvalid);
        }
    }
}
