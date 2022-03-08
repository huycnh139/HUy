using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }


        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public string UserAcc { get; set; }
        
        [Required]
        public string PassWord { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        public ShipDetail ShipDetails { get; set; }
    }
}
