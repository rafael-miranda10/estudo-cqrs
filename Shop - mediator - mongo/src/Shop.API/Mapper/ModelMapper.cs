using AutoMapper;
using Shop.API.Domain.Commands.Requests;
using Shop.API.Domain.Commands.Responses;
using Shop.API.Domain.Entities;

namespace Shop.API.Mapper
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<CreateCustomerResponse, Customer>().ReverseMap();
            CreateMap<CreateCustomerRequest, Customer>().ReverseMap();
            CreateMap<UpdateCustomerRequest, Customer>().ReverseMap();
        }
    }
}
