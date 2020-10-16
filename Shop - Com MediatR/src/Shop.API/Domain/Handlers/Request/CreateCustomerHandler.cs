using MediatR;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shop.API.Domain.Handlers.Request
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
      
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //verifica se o cliente ja esta cadastrado
            //valida os dados
            //mapea request para cliente
            //insere o cliente
            //envia o email de boas vindas
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Rafael Arthur Rocha Miranda",
                Email = "arthur.rafa10@gmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
