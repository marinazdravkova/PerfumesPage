using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Models;
using Products.Application.Repositories.CardRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Interface;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Repositories.CardRepository.Service
{
    public class CardService : ICardService
    {
        private readonly IProductDbContext _dbContext;
        private readonly IMapper _mapper;

        public CardService(IProductDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> Add(CardModelDto entity, string id)
        {
            //Validation to check if PerfumeModelDto has all required fields
            Card card = _mapper.Map<CardModelDto, Card>(entity);

            card.CreatedOn = DateTime.Now;

            card.Id = Guid.NewGuid();

            _dbContext.Cards.Add(card);

            await _dbContext.SaveChangesAsync();

            return "Card is addded!";

        }

        public async Task<string> Delete(Guid id)
        {
            Card card = await _dbContext.Cards.FindAsync(id);

            if (card == null)
            {
                return "Perfume doesnt exist";
            }

            _dbContext.Cards.Remove(card);

            await _dbContext.SaveChangesAsync();

            return $"Card with id {id} is deleted";
        }

        public async Task<CardModelDto> Get(Guid id)
        {
            Card card = await _dbContext.Cards.Include(x => x.Items).ThenInclude(item => item.Perfume)
            .ThenInclude(perfume => perfume.Brand).FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Card, CardModelDto>(card);
        }

        public async Task<List<CardModelDto>> GetAll()
        {
            List<Card> dbCards = await _dbContext.Cards.Include(x => x.Items).ThenInclude(item => item.Perfume)
            .ThenInclude(perfume => perfume.Brand).ToListAsync();

            List<CardModelDto> cardsDtos = new();

            foreach (Card item in dbCards)
            {
                CardModelDto cardDto = _mapper.Map<Card, CardModelDto>(item);

                cardsDtos.Add(cardDto);
            }

            return cardsDtos;
        }

        public async Task<string> Update(CardModelDto entity, string Id)
        {
            Card card = await _dbContext.Cards.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (card is null)
            {
                return $"Card with id {entity.Id} doesnt exist!";
            }

            card = _mapper.Map<CardModelDto, Card>(entity);

            card.ModifiedOn = DateTime.Now;

            _dbContext.Cards.Update(card);

            await _dbContext.SaveChangesAsync();

            return $"Card with id {entity.Id} is updated";
        }
    }
}
