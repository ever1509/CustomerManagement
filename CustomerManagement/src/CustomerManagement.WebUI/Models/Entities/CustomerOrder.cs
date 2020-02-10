using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.WebUI.Models.Entities
{
    public class CustomerOrder
    {
        public int CustomerOrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime? OrderCreated { get; set; }
        public bool OrderStatus { get; set; }
    }
}
