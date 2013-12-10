namespace OrganizingData.ChangeBidirectionalAssociationToUnidirectional
{
    public class Order
    {
        private readonly string name;

        private Customer customer;

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

        public void SetCustomer(Customer customer)
        {
            if (this.customer != null) this.customer.FriendOrders().Remove(this);
            this.customer = customer;
            if (this.customer != null) this.customer.FriendOrders().Add(this);
        }

        public double GetDiscountedPrice()
        {
            const double grossPrice = 10.0;
            return grossPrice * (1 - customer.GetDiscount());
        }
    }
}