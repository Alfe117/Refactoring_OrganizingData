using OrganizingData.EncapsulateField;
using Xunit;

namespace OrganizingDataFacts
{
    public class EncapsulateFieldFact
    {
        [Fact]
        public void should_get_name()
        {
            var encapsulateField = new EncapsulateField();
            encapsulateField.name = "Kent";
            Assert.Equal("Kent", encapsulateField.name);
        }
    }
}