namespace OrganizingData.ChangeValueToReference
{
    public class Customer
    {
        private readonly string customerName;

        public Customer(string customerName)
        {
            this.customerName = customerName;
        }

        public string CustomerName
        {
            get { return customerName; }
        }
    }
}