using GraphQL.Types;
using GraphQlDemo.Data.Services;

namespace GraphQlDemo.Data.Schema
{
    public class OrdersQuery : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderService orders)
        {
            Name = "Query";
            Field<ListGraphType<OrderType>>("orders",
                resolve: context => orders.GetOrdersAsync());
        }
    }
}
