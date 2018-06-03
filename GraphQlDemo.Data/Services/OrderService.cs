using GraphQlDemo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQlDemo.Data.Services
{
    public class OrderService : IOrderService
    {
        private IList<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>();
            _orders.Add(new Order("1000", "Some Stuff Wanted",
                DateTime.Now, 1, "1792327d-5ba3-43f2-8b3e-52c8e1f43320"));
            _orders.Add(new Order("1003", "Some Stuff Wanted 2",
                DateTime.Now, 2, "a4248c12-27c8-4145-a0bc-9f18acd2bd46"));
            _orders.Add(new Order("1002", "Some Stuff Wanted 32",
                DateTime.Now, 3, "4601327b-2b8b-4433-983b-f8453a49554c"));
            _orders.Add(new Order("1001", "Some Stuff Wanted 3",
                DateTime.Now, 4, "ee7bf89c-7aa8-4b61-8c33-a3b400b09085"));
        }

        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(x => Equals(x.Id, id)));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }

    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
