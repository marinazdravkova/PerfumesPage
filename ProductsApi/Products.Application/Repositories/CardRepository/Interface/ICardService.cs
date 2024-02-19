using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.CardRepository.Interface
{
    public interface ICardService : IServiceRepository<CardModelDto>
    {
        Task<string> Update(CardModelDto entity, string Id);
    }
}
