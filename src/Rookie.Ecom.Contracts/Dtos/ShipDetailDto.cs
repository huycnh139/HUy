using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class ShipDetailDto
    {
        public Guid Id { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int Phone { get; set; }

        public UserDto UserDto { get; set; }
    }
}
