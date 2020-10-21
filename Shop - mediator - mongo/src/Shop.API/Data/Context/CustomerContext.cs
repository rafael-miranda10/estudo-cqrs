using MongoDB.Driver;
using Shop.API.Domain.Entities;

namespace Shop.API.Data.Context
{
    public class CustomerContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public CustomerContext()
        {
            var mdbClient = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = mdbClient.GetDatabase("CustomerDB");
        }
        public IMongoCollection<Customer> Customer
        {
            get
            {
                return _mongoDatabase.GetCollection<Customer>("Customer");
            }
        }

    }
}
