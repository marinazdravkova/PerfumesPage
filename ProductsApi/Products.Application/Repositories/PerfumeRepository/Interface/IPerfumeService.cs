using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.PerfumeRepository.Interface
{
    public interface IPerfumeService : IServiceRepository<PerfumeModelDto>
    {
        Task<string> Update(PerfumeModelDto entity, string Id);
    }
}
