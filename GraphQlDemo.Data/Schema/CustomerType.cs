using GraphQL.Types;
using GraphQlDemo.Data.Models;

namespace GraphQlDemo.Data.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}
