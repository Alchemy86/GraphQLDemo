using System;

namespace GraphQlDemo.Data.Models
{
    public class Order
    {
        public Order(string name, 
            string description, 
            DateTime created, 
            int customerId, 
            string id)
        {
            Name = name;
            Description = description;
            Created = created;
            CustomerId = customerId;
            Id = id;
        }

        public string Name { get; }
        public string Description { get; }
        public DateTime Created { get; }
        public int CustomerId { get; }
        public string Id { get;  }
    }

    [Flags]
    public enum OrderStatus
    {
        Created = 2,
        Processing = 4,
        Completed = 8,
        Cancelled = 16,
        Closed = 32
    }
}
