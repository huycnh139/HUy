using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("OrderItem")]
    public class OrderItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        [Column(TypeName ="Money")]
        public decimal Price { get; set; }

        public ICollection<Product> Products { get; set; }

        public int Quantity { get; set; }
    }
}
