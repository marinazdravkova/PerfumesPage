using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Models
{
    public record PerfumeModelDto (Guid Id, string Name, string Description, string ImageURL, int Price, string? PerfumeType, string? Season, Guid BrandId, BrandModelDto Brand);
    
}
