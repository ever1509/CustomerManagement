using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Entities
{
    public class Customer
    {
        public Customer()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
        }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerFullName { get { return CustomerName + " " + CustomerLastName; } }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public bool CustomerStatus { get; set; }
        public DateTime? CustomerCreated { get; set; }

        public ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
