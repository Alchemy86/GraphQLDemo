using GraphQL.Types;
using GraphQlDemo.Data.Models;
using GraphQlDemo.Data.Services;

namespace GraphQlDemo.Data.Schema
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customerService)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description);
            Field<CustomerType>("bully", 
                resolve: context => 
                    customerService.GetCustomerByIdAsync(context.Source.CustomerId));
            Field(x => x.Created);
        }
    }
}
