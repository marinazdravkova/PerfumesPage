using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using Products.Application.Repositories.BrandRepository.Interface;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.BrandRepository.Service
{
    public class BrandService : IBrandService
    {
        private readonly IProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public BrandService(IProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Add(BrandModelDto entity, string Id)
        {
            Brand brand = _mapper.Map<BrandModelDto, Brand>(entity);
            brand.CreatedOn = DateTime.Now;

            brand.Id = Guid.Parse(Id);

            _dbContext.Brands.Add(brand);

            await _dbContext.SaveChangesAsync();

            return "Brand addded!";
        }

        public async Task<string> Delete(Guid id)
        {
            Brand brand = await _dbContext.Brands.FindAsync(id);

            if (brand == null)
            {
                return "Brand doesnt exist";
            }

            _dbContext.Brands.Remove(brand);

            await _dbContext.SaveChangesAsync();

            return $"Brand with id {id} is deleted";
        }

        public async Task<BrandModelDto> Get(Guid id)
        {
            Brand brand = await _dbContext.Brands.FindAsync(id);
            brand = await _dbContext.Brands.FindAsync(id);

            return _mapper.Map<Brand, BrandModelDto>(brand);
        }

        public async Task<List<BrandModelDto>> GetAll()
        {
            List<Brand> dbBrands = await _dbContext.Brands.ToListAsync();

            List<BrandModelDto> brandsDtos = new();

            foreach (Brand item in dbBrands)
            {
                BrandModelDto brandDto = _mapper.Map<Brand, BrandModelDto>(item);

                brandsDtos.Add(brandDto);
            }

            return brandsDtos;
        }

        public async Task<string> Update(BrandModelDto entity)
        {

            Brand brand = await _dbContext.Brands.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (brand is null)
            {
                return $"Brand with id {entity.Id} doesnt exist!";
            }

            brand = _mapper.Map<BrandModelDto, Brand>(entity);

            brand.ModifiedOn = DateTime.Now;

            _dbContext.Brands.Update(brand);

            await _dbContext.SaveChangesAsync();

            return $"Brand with id {entity.Id} is updated";
        }
    }
}
