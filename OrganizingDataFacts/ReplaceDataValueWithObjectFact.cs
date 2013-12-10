using System.Collections.Generic;
using System.Linq;
using OrganizingData.ReplaceDataValueWithObject;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceDataValueWithObjectFact
    {
        [Fact]
        public void should_get_number_of_orders_for_customer()
        {
            var orders = new List<Order> {new Order("Kent"), new Order("Kent"), new Order("Martin")};
            Assert.Equal(2, NumberOfOrdersFor(orders, "Kent"));
        }

        public static int NumberOfOrdersFor(IEnumerable<Order> orders, string customer)
        {
            return orders.Count(o => o.Customer == customer);
        }
    }
}