using AutoMapper;
using EnsureThat;
using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.Business.Interfaces;
using Rookie.Ecom.Contracts;
using Rookie.Ecom.Contracts.Dtos;
using Rookie.Ecom.DataAccessor.Entities;
using Rookie.Ecom.DataAccessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rookie.Ecom.Business.Services
{
    public class ProductImageService : IProductImageService
    {
        private readonly IBaseRepository<ProductImage> _baseRepository;
        private readonly IMapper _mapper;

        public ProductImageService(IBaseRepository<ProductImage> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public async Task<ProductImageDto> AddAsync(ProductImageDto productImageDto)
        {
            if (productImageDto == null)
                throw new ArgumentNullException();

            var productImage = _mapper.Map<ProductImage>(productImageDto);
            var item = await _baseRepository.AddAsync(productImage);
            return _mapper.Map<ProductImageDto>(item);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(ProductImageDto productImageDto)
        {
            var productImage = _mapper.Map<ProductImage>(productImageDto);
            await _baseRepository.UpdateAsync(productImage);
        }

        public async Task<IEnumerable<ProductImageDto>> GetAllAsync()
        {
            var productImages = await _baseRepository.GetAllAsync();
            return _mapper.Map<List<ProductImageDto>>(productImages);
        }

        public async Task<ProductImageDto> GetByIdAsync(Guid id)
        {
            // map roles and users: collection (roleid, userid)
            // upsert: delete, update, insert
            // input vs db
            // input-y vs db-no => insert
            // input-n vs db-yes => delete
            // input-y vs db-y => update
            // unique, distinct, no-duplicate
            var productImage = await _baseRepository.GetByIdAsync(id);
            return _mapper.Map<ProductImageDto>(productImage);
        }

        public async Task<ProductImageDto> GetByNameAsync(string name)
        {
            var productImage = await _baseRepository.GetByAsync(x => x.Name == name);
            return _mapper.Map<ProductImageDto>(productImage);
        }

        public async Task<PagedResponseModel<ProductImageDto>> PagedQueryAsync(string name, int page, int limit)
        {
            var query = _baseRepository.Entities;

            query = query.Where(x => string.IsNullOrEmpty(name) || x.Name.Contains(name));

            query = query.OrderBy(x => x.Name);

            var assets = await query
                .AsNoTracking()
                .PaginateAsync(page, limit);

            return new PagedResponseModel<ProductImageDto>
            {
                CurrentPage = assets.CurrentPage,
                TotalPages = assets.TotalPages,
                TotalItems = assets.TotalItems,
                Items = _mapper.Map<IEnumerable<ProductImageDto>>(assets.Items)
            };
        }
    }
}
