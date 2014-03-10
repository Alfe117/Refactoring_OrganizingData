using OrganizingData.ChangeValueToReference;
using Xunit;

namespace OrganizingDataFacts
{
    public class ChangeValueToReferenceFact
    {
        [Fact]
        public void should_get_number_of_orders_for_customer()
        {
            var kentOrder1 = new Order("Kent");
            var kentOrder2 = new Order("Kent");
            Assert.Equal("Kent", kentOrder1.Customer.CustomerName);
            Assert.Equal("Kent", kentOrder2.Customer.CustomerName);

            // Should Pass
//            Assert.Equal(kentOrder1.Customer, kentOrder2.Customer);
        }
    }
}