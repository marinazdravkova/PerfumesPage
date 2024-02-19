using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using Products.Application.Repositories.PerfumeRepository.Interface;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.PerfumeRepository.Service
{
    public class PerfumeService : IPerfumeService
    {
        private readonly IProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public PerfumeService(IProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Add(PerfumeModelDto entity, string id)
        {
            //Validation to check if PerfumeModelDto has all required fields
            Perfume perfume = _mapper.Map<PerfumeModelDto, Perfume>(entity);

            perfume.CreatedOn = DateTime.Now;

            perfume.Id = Guid.Parse(id);

            _dbContext.Perfumes.Add(perfume);

            await _dbContext.SaveChangesAsync();

            return "Perfume addded!";
        }


        public async Task<string> Delete(Guid id)
        {
            Perfume perfume = await _dbContext.Perfumes.FindAsync(id);

            if (perfume == null)
            {
                return "Perfume doesnt exist";
            }

            _dbContext.Perfumes.Remove(perfume);

            await _dbContext.SaveChangesAsync();

            return $"Perfume with id {id} is deleted";

        }

        public async Task<PerfumeModelDto> Get(Guid id)
        {
            Perfume perfume = await _dbContext.Perfumes.Include(x => x.Brand).FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Perfume, PerfumeModelDto>(perfume);
        }

        public async Task<List<PerfumeModelDto>> GetAll()
        {
            List<Perfume> dbPerfumes = await _dbContext.Perfumes.Include(x => x.Brand).ToListAsync();

            List<PerfumeModelDto> perfumesDtos = new();

            foreach (Perfume item in dbPerfumes)
            {
                PerfumeModelDto perfumeDto = _mapper.Map<Perfume, PerfumeModelDto>(item);

                perfumesDtos.Add(perfumeDto);
            }

            return perfumesDtos;
        }

        public async Task<string> Update(PerfumeModelDto entity, string Id)
        {
            Perfume perfume = await _dbContext.Perfumes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (perfume is null)
            {
                return $"Perfume with id {entity.Id} doesnt exist!";
            }

            perfume = _mapper.Map<PerfumeModelDto, Perfume>(entity);

            perfume.ModifiedOn = DateTime.Now;

            _dbContext.Perfumes.Update(perfume);

            await _dbContext.SaveChangesAsync();

            return $"Perfume with id {entity.Id} is updated";
        }
    }
}
