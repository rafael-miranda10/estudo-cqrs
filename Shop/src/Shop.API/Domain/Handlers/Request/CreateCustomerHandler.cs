using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;
using Shop.API.Domain.Handlers.Interfaces;
using System;

namespace Shop.API.Domain.Handlers.Request
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            //verifica se o cliente ja esta cadastrado
            //valida os dados
            //mapea request para cliente
            //insere o cliente
            //envia o email de boas vindas
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Rafael Arthur Rocha Miranda",
                Email = "arthur.rafa10@gmail.com",
                Date = DateTime.Now
            };
        }
    }
}
