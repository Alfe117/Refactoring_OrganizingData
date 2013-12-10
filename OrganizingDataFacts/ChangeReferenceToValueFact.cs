using OrganizingData.ChangeReferenceToValue;
using Xunit;

namespace OrganizingDataFacts
{
    public class ChangeReferenceToValueFact
    {
        [Fact]
        public void should_two_currencies_with_the_same_unit_are_equal()
        {
            Assert.Equal(Currency.Get("USD"), Currency.Get("USD"));
        }
    }
}