using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Models
{
    public record CardItemDto(Guid Id, int Quantity, decimal Price, decimal TotalPrice, Guid PerfumeId);

}
