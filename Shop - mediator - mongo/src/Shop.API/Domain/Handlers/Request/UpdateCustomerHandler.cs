using AutoMapper;
using MediatR;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Common;
using Shop.API.Domain.Entities;
using Shop.API.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.API.Domain.Handlers.Request
{
    public class UpdateCustomerHandler : Handler, IRequestHandler<UpdateCustomerRequest, RequestResult>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public UpdateCustomerHandler(
            IMapper mapper,
            ICustomerRepository customerRepository
            )
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<RequestResult> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            request.ValidateCommand();
            if (!request.IsValid())
            {
                AddNotifications(request.ValidationResult);
            }

            //poderia ter outras regras de negocio, como por exemplo verificar se não existe cliente com o mesmo nome


            if (!RequestResult.HasNotifications())
            {
                var customer = _mapper.Map<Customer>(request);
                customer.SetDateForCustomer();
                await _customerRepository.Update(customer);
            }

            return await Task.FromResult(RequestResult);
        }
    }
}
