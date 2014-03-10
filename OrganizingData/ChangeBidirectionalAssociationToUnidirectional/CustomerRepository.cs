using System.Collections.Generic;

namespace OrganizingData.ChangeBidirectionalAssociationToUnidirectional
{
    public class CustomerRepository
    {
        private static readonly List<Customer> Customers = new List<Customer>();
        public static List<Customer> GetInstances()
        {
            return Customers;
        }

        public static void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
    }
}