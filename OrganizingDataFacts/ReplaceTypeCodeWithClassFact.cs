using OrganizingData.ReplaceTypeCodeWithClass;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceTypeCodeWithClassFact
    {
        [Fact]
        public void should_get_blood_of_person()
        {
            var person = new Person(1);
            Assert.Equal(1, person.BloodGroup);
        }
    }
}