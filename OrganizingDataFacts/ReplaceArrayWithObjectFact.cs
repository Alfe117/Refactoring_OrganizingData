using OrganizingData.ReplaceArrayWithObject;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceArrayWithObjectFact
    {
        [Fact]
        public void should_get_name_and_wins_given_init_row()
        {
            var row = new[]{"Liverpool", "15"};
            var replaceArrayWithObject = new ReplaceArrayWithObject(row);
            Assert.Equal("Liverpool", replaceArrayWithObject.Name);
            Assert.Equal(15, replaceArrayWithObject.Wins);
        }
    }
}