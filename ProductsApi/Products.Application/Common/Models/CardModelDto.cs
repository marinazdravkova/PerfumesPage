﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Models
{
    public record CardModelDto (Guid Id, decimal TotalPrice, List<CardItemModelDto> Items);
    
}
