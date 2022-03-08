using System;

namespace Rookie.Ecom.Contracts.Dtos
{
    public class ProductDto
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public CategoryDto CategoryDto { get; set; }
    }
}
