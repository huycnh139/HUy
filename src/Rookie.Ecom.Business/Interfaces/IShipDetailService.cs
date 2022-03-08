using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Interfaces
{
    public interface IShipDetailService
    {
        Task<IEnumerable<ShipDetailDto>> GetAllAsync();

        Task<PagedResponseModel<ShipDetailDto>> PagedQueryAsync(string name, int page, int limit);

        Task<ShipDetailDto> GetByIdAsync(Guid id);

        Task<ShipDetailDto> GetByNameAsync(string name);

        Task<ShipDetailDto> AddAsync(ShipDetailDto shipDetailDto);

        Task DeleteAsync(Guid id);

        Task UpdateAsync(ShipDetailDto shipDetailDto);
    }
}
