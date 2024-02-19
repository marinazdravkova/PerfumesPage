using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.BrandRepository.Interface
{
    public interface IBrandService : IServiceRepository<BrandModelDto>
    {
        Task<string> Update(BrandModelDto entity);
    }
}
