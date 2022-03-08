using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class OrderItemDto
    {
        public Guid Id { get; set; }

        public OrderDto OrderDto { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
