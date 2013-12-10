using System.Collections.Generic;
using OrganizingData.ChangeUnidirectionalAssociationToBidirectional;
using System.Linq;
using Xunit;

namespace OrganizingDataFacts
{
    public class ChangeUnidirectionalAssociationToBidirectionalFact
    {
        [Fact]
        public void should_get_orders_of_customer()
        {
            var kent = new Customer("Kent");
            var martin = new Customer("Martin");
            var foodForKent = new Order(kent, "Food");
            var musicForKent = new Order(kent, "Music");
            var foodForMartin = new Order(martin, "Food");

            var orders = new List<Order> {foodForKent, musicForKent, foodForMartin};
            Assert.Equal(2, GetCustomerOrders(orders, "Kent").Count);
        }

        private static List<Order> GetCustomerOrders(IEnumerable<Order> orders, string customerName)
        {
            return orders.Where(o => o.GetCustomer().GetName() == customerName).ToList();
        }
    }
}