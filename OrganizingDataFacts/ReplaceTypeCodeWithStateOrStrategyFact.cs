using OrganizingData.ReplaceTypeCodeWithStateOrStrategy;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceTypeCodeWithStateOrStrategyFact
    {
        [Fact]
        public void should_get_pay_amount_for_engineer()
        {
            var employee = new Employee(0);
            var payAmount = employee.PayAmount(10, 20, 30);
            Assert.Equal(10, payAmount);
        }

        [Fact]
        public void should_get_pay_amount_for_sales_man()
        {
            var employee = new Employee(1);
            var payAmount = employee.PayAmount(10, 20, 30);
            Assert.Equal(30, payAmount);
        }

        [Fact]
        public void should_get_pay_amount_for_manager()
        {
            var employee = new Employee(2);
            var payAmount = employee.PayAmount(10, 20, 30);
            Assert.Equal(40, payAmount);
        }
    }
}