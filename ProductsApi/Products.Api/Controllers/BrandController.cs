using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Common.Models;
using Products.Application.Repositories.BrandRepository.Interface;
using Products.Entities;
using System.Data;

namespace Products.Api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly UserManager<ApplicationUser> _userManager;

        public BrandController(IBrandService brandService, UserManager<ApplicationUser> userManager)
        {
            _brandService = brandService;
            _userManager = userManager;
        }

        // GET: <BrandController>
        [HttpGet("getAll")]
        public async Task<IEnumerable<BrandModelDto>> GetAll()
        {
            List<BrandModelDto> brands = await _brandService.GetAll();

            return brands;
        }

        // GET <BrandController>/5
        [HttpGet("{id}")]
        public async Task<BrandModelDto> GetById(Guid id)
        {
            BrandModelDto brandDto = await _brandService.Get(id);

            return brandDto;
        }

        // POST <BrandController>
        [HttpPost("addBrand")]
        public async Task<string> Post([FromBody] BrandModelDto value)
        {
            ApplicationUser currentUser = await _userManager.FindByNameAsync(User.Claims?.FirstOrDefault()?.Value);

            var user = currentUser == null ? Guid.Empty.ToString() : currentUser.Id;
            string response = await _brandService.Add(value, user);

            return response;
        }

        // PUT <BrandController>/5
        [HttpPut("updateBrand")]
        public async Task<string> Put([FromBody] BrandModelDto value)
        {
         

            string response = await _brandService.Update(value);

            return response;
        }

        // DELETE <BrandController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(Guid id)
        {
            string response = await _brandService.Delete(id);

            return response;

        }
    }

   
}
