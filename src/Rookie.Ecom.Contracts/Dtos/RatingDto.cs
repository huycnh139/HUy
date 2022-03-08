using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class RatingDto
    {
        public Guid Id { get; set; }

        public ProductDto ProductDto { get; set; }

        public UserDto UserDto { get; set; }

        public decimal Ratting { get; set; }

        public string Comment { get; set; }
    }
}
