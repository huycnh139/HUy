using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Entities
{
    [Table("ProductImage")]
    public class ProductImage
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set;}

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        [Required]
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        public string ImageUrl { get; set; }
    }
}
