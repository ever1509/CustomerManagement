using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Entities
{
    public class Product
    {
        public Product()
        {
            CustomerOrders = new HashSet<CustomerOrder>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public DateTime? ProductCreated { get; set; }
        public bool ProductStatus { get; set; }

        public ICollection<CustomerOrder> CustomerOrders { get; set; }
    }
}
