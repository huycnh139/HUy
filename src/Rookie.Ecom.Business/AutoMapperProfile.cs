using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor.Entities;

namespace Rookie.Ecom.Business
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            FromDataAccessorLayer();
            FromPresentationLayer();
        }

        private void FromPresentationLayer()
        {
            CreateMap<CategoryDto, Category>()
               .ForMember(d => d.ImageUrl, t => t.Ignore());
            CreateMap<ProductDto, Product>();
            CreateMap<ProductImageDto, ProductImage>();
            CreateMap<UserDto, User>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderItemDto, OrderItem>();
            CreateMap<RatingDto, Rating>();
            CreateMap<ShipDetailDto, ShipDetail>();
        }

        private void FromDataAccessorLayer()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductImage, ProductDto>();
            CreateMap<User, UserDto>();
            CreateMap<Order, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<Rating, RatingDto>();
            CreateMap<ShipDetail, ShipDetailDto>();
        }


    }
}
