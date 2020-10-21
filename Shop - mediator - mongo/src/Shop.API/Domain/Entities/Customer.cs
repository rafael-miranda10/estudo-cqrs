using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Shop.API.Domain.Entities
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; private set; }
        [BsonElement]
        public string Name { get; private set; }
        [BsonElement]
        public string Email { get; private set; }
        [BsonElement]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; private set; }

        public Customer() {}
        public Customer(string id,string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Date = DateTime.Now;
        }

        public void SetDateForCustomer()
        {
            Date = DateTime.Now;
        }
    }
}
