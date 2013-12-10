namespace OrganizingData.ChangeUnidirectionalAssociationToBidirectional
{
    public class Customer
    {
        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}