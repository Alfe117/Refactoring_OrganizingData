using OrganizingData.ReplaceMagicNumberWithSymbolicConstant;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceMagicNumberWithSymbolicConstantFact
    {
        [Fact]
        public void should_get_potential_energy()
        {
            var energyCalculator = new EnergyCalculator();
            var potentialEnergy = energyCalculator.PotentialEnergy(10, 10);
            Assert.Equal(981, potentialEnergy);
        }
    }
}