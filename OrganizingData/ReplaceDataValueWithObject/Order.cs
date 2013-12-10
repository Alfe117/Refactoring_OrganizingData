namespace OrganizingData.ReplaceDataValueWithObject
{
    public class Order
    {
        private readonly string customer;

        public Order(string customer)
        {
            this.customer = customer;
        }

        public string Customer
        {
            get { return customer; }
        }
    }
}