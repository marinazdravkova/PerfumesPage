using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Models
{
    public record BrandModelDto (Guid Id, string Name, string Description, string Country);
   
}
