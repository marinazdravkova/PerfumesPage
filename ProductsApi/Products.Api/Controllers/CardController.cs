using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Common.Models;
using Products.Application.Repositories.CardRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Service;
using Products.Entities;
using System.Data;

namespace Products.Api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CardController(ICardService cardService, UserManager<ApplicationUser> userManager)
        {
            _cardService = cardService;
            _userManager = userManager;
        }
        
        // GET:<CardController>
        [HttpGet("getAll")]
        public async Task<IEnumerable<CardModelDto>> GetAll()
        {
            
            List<CardModelDto> cards = await _cardService.GetAll();

            return cards;
        }

        // GET <CardController>/5
        [HttpGet("{id}")]
        public async Task<CardModelDto> GetById(Guid id)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Claims?.FirstOrDefault()?.Value);
            CardModelDto cardDto = await _cardService.Get(id);
            return cardDto;

        }

        // POST <CardController>
        [HttpPost("addCard")]
        public async Task<string> Post([FromBody] CardModelDto value)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Claims?.FirstOrDefault()?.Value);

            string response = await _cardService.Add(value, user.Id);

            return response;
        }

        // PUT <CardController>/5
        [HttpPut("updateCard")]
        public async Task<string> Put([FromBody] CardModelDto value)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Claims?.FirstOrDefault()?.Value);
            string response = await _cardService.Update(value, user.Id);

            return response;
        }

        // DELETE <CardController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(Guid id)
        {
            var response = await _cardService.Delete(id);

            return response;
        }
    }
}
