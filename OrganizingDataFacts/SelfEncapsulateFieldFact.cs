using OrganizingData.SelfEncapsulateField;
using Xunit;

namespace OrganizingDataFacts
{
    public class SelfEncapsulateFieldFact
    {
        [Fact]
        public void should_not_include_when_number_is_less_than_low_and_greater_than_high()
        {
            var intRange = new IntRange(50, 100);
            Assert.False(intRange.Includes(150));
        }

        [Fact]
        public void should_include_when_after_number_grow_is_between_low_and_high()
        {
            var intRange = new IntRange(50, 100);
            intRange.Grow(2);
            Assert.True(intRange.Includes(150));
        }

        [Fact]
        public void should_include_when_number_is_between_low_and_high()
        {
            var intRange = new IntRange(50, 100);
            Assert.True(intRange.Includes(80));
        }

    }
}
