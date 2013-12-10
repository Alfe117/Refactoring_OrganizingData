namespace OrganizingData.ReplaceTypeCodeWithClass
{
    public class Client
    {
        public void UpdateBloodGroup()
        {
            var person = new Person(Person.AB);
            var bloodGroup = person.BloodGroup;
        }
    }
}