using MongoDB.Driver;
using Shop.API.Data.Context;
using Shop.API.Domain.Entities;
using Shop.API.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.API.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerContext _customerContext;

        public CustomerRepository(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public async Task Add(Customer customer)
        {
            await _customerContext.Customer.InsertOneAsync(customer);
        }

        public async Task Delete(string id)
        {
            FilterDefinition<Customer> filtro = Builders<Customer>.Filter.Eq("Id", id);
            await _customerContext.Customer.DeleteOneAsync(filtro);
        }

        public async Task<Customer> GetCustomer(string id)
        {
            FilterDefinition<Customer> filtro = Builders<Customer>.Filter.Eq("Id", id);
            return await _customerContext.Customer.Find(filtro).FirstOrDefaultAsync();
        }

        public async Task<Customer> GetCustomerByName(string name)
        {
            FilterDefinition<Customer> filtro = Builders<Customer>.Filter.Eq("Name", name);
            return await _customerContext.Customer.Find(filtro).FirstOrDefaultAsync();
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _customerContext.Customer.Find(x => true).ToListAsync();
        }

        public async Task Update(Customer customer)
        {
            await _customerContext.Customer.ReplaceOneAsync(x => x.Id == customer.Id, customer);
        }
    }
}
