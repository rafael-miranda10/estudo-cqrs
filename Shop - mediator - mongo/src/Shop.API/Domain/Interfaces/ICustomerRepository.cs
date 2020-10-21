using Shop.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.API.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(string id);
        Task<Customer> GetCustomer(string id);
        Task<Customer> GetCustomerByName(string name);
        Task<List<Customer>> GetCustomers();
    }
}
