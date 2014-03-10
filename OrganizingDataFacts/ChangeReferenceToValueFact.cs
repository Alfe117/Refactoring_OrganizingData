using OrganizingData.ChangeReferenceToValue;
using Xunit;

namespace OrganizingDataFacts
{
    public class ChangeReferenceToValueFact
    {
        [Fact]
        public void should_two_currencies_with_the_same_unit_are_equal()
        {
            var usdCurrency1 = new Currency("USD");
            var usdCurrency2 = new Currency("USD");

            Assert.Equal(usdCurrency1.Code, usdCurrency2.Code);
            // Should Pass
//            Assert.Equal(usdCurrency1, usdCurrency2);
        }
    }
}