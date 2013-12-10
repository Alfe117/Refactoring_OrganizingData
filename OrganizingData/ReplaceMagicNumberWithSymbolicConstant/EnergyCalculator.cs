namespace OrganizingData.ReplaceMagicNumberWithSymbolicConstant
{
    public class EnergyCalculator
    {
        public decimal PotentialEnergy(decimal mass, decimal height)
        {
            return mass*9.81M*height;
        }
    }
}