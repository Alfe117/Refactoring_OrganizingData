using System.Collections.Generic;
using System.Linq;
using OrganizingData.ChangeBidirectionalAssociationToUnidirectional;
using Xunit;

namespace OrganizingDataFacts
{
    public class ChangeBidirectionalAssociationToUnidirectionalFact
    {
        [Fact]
        public void should_get_orders_of_customer()
        {
            var kent = new Customer("Kent");
            var martin = new Customer("Martin");

            var foodForKent = new Order(kent, "Food");
            var musicForKent = new Order(kent, "Music");
            var foodForMartin = new Order(martin, "Food");
            
            kent.AddOrder(foodForKent);
            kent.AddOrder(musicForKent);
            martin.AddOrder(foodForMartin);
            var orders = new List<Order> {foodForKent, musicForKent, foodForMartin};
            Assert.Equal(2, GetCustomerOrders(orders, "Kent").Count);
            Assert.Equal(9, kent.GetPriceFor(foodForKent));
        }

        private static List<Order> GetCustomerOrders(IEnumerable<Order> orders, string customerName)
        {
            return orders.Where(o => o.GetCustomer().GetName() == customerName).ToList();
        }
    }
}