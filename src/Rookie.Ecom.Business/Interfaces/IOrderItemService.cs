using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface IOrderItemService
    {
        Task<IEnumerable<OrderItemDto>> GetAllAsync();

        Task<PagedResponseModel<OrderItemDto>> PagedQueryAsync(string name, int page, int limit);

        Task<OrderItemDto> GetByIdAsync(Guid id);

        Task<OrderItemDto> AddAsync(OrderItemDto orderItemDto);

        Task DeleteAsync(Guid id);
    }
}
