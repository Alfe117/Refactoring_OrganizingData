using OrganizingData.ReplaceTypeCodeWithSubclasses;
using Xunit;

namespace OrganizingDataFacts
{
    public class ReplaceTypeCodeWithSubclassesFact
    {
        [Fact]
        public void should_get_type_of_employee()
        {
            var employee = new Employee(1);
            Assert.Equal(Employee.SALESMAN, employee.Type);
        }
    }
}