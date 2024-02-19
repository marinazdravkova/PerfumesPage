using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Models
{
    public record CardDto(Guid Id, decimal TotalPrice, List<CardItemDto> Items);
}
