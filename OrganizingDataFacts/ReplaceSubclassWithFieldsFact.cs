using OrganizingData.ReplaceSubclassWithFields;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceSubclassWithFieldsFact
    {
        [Fact]
        public void should_get_M_code_given_is_male()
        {
            var male = new Male();
            Assert.Equal("M", male.GetCode());
        }

        [Fact]
        public void should_get_F_code_given_is_male()
        {
            var feMale = new FeMale();
            Assert.Equal("F", feMale.GetCode());
        }
    }
}