using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        public Guid UserId { get; set; }
        [Required]
        public DateTime OrerDate { get; set; }
        
        public User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }

        public ShipDetail ShipDetail { get; set; }
    }
}
