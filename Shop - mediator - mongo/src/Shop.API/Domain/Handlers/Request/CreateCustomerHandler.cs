using AutoMapper;
using MediatR;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Common;
using Shop.API.Domain.Common.Resources;
using Shop.API.Domain.Entities;
using Shop.API.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.API.Domain.Handlers.Request
{
    public class CreateCustomerHandler : Handler, IRequestHandler<CreateCustomerRequest, RequestResult>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerHandler(
            IMapper mapper,
            ICustomerRepository customerRepository
            )
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        public async Task<RequestResult> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            request.ValidateCommand();
            if (!request.IsValid())
            {
                AddNotifications(request.ValidationResult);
                return await Task.FromResult(RequestResult);
            }

            //poderia ter outras regras de negocio, como por exemplo verificar se não existe cliente com o mesmo nome
            var customerExist = await _customerRepository.GetCustomerByName(request.Name);
            if (customerExist != null) AddNotification(Resource.CustomerAlreadyExists);

            if (!RequestResult.HasNotifications())
            {
                var customer = _mapper.Map<Customer>(request);
                customer.SetDateForCustomer();
                await _customerRepository.Add(customer);
            }

            return await Task.FromResult(RequestResult);
        }
    }
}
