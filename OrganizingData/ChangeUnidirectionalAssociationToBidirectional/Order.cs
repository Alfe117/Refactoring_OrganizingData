namespace OrganizingData.ChangeUnidirectionalAssociationToBidirectional
{
    public class Order
    {
        private readonly string name;

        private readonly Customer customer;

        public Order(Customer customer, string name)
        {
            this.customer = customer;
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public Customer GetCustomer()
        {
            return customer;
        }
    }
}