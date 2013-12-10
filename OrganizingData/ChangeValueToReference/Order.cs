namespace OrganizingData.ChangeValueToReference
{
    public class Order
    {
        private readonly Customer customer;

        public Order(string customer)
        {
            this.customer = new Customer(customer);
        }

        public Customer Customer
        {
            get { return customer; }
        }
    }
}