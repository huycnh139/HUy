using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("ShipDetail")]
    public class ShipDetail 
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        

        //[Required]
        //public Guid OrderId { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public User User { get; set; }

        //public Order Order { get; set; }
    }
}
