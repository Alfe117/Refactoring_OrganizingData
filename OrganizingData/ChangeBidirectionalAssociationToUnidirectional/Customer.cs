using System.Collections.Generic;

namespace OrganizingData.ChangeBidirectionalAssociationToUnidirectional
{
    public class Customer
    {
        private readonly string name;
        private readonly List<Order> orders = new List<Order>();

        public Customer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void AddOrder(Order order)
        {
            order.SetCustomer(this);
        }

        internal List<Order> FriendOrders()
        {
            return orders;
        }

        public double GetDiscount()
        {
            return 0.1;
        }

        public double GetPriceFor(Order order)
        {
            return order.GetDiscountedPrice();
        }
    }
}