using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Common.Models;
using Products.Application.Repositories.PerfumeRepository.Interface;
using Products.Application.Repositories.PerfumeRepository.Service;
using Products.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Api.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class PerfumeController : ControllerBase
    {
        private readonly IPerfumeService _perfumeService;
        private readonly UserManager<ApplicationUser> _userManager;

        public PerfumeController(IPerfumeService perfumeService, UserManager<ApplicationUser> userManager)
        {
            _perfumeService = perfumeService;
            _userManager = userManager;
        }

        // GET: api/<PerfumeController>
        [HttpGet("getAll")]
        public async Task<IEnumerable<PerfumeModelDto>> GetAll()
        {
            List<PerfumeModelDto> perfumes = await _perfumeService.GetAll();

            return perfumes;
        }

        // GET api/<PerfumeController>/5
        [HttpGet("{id}")]
        public async Task<PerfumeModelDto> GetById(Guid id)
        {
            PerfumeModelDto perfumeDto = await _perfumeService.Get(id);
            return perfumeDto;

        }

        // POST api/<PerfumeController>
        [HttpPost("addPerfume")]
        public async Task<string> Post([FromBody] PerfumeModelDto value)
        {
            ApplicationUser currentUser = await _userManager.GetUserAsync(User);

            var user = currentUser == null ? Guid.Empty.ToString() : currentUser.Id;
            string response = await _perfumeService.Add(value, user);


            return response;
        }

        // PUT api/<PerfumeController>/5
        [HttpPut("updatePerfume")]
        public async Task<string> Put([FromBody] PerfumeModelDto value)
        {
            ApplicationUser user = await _userManager.FindByNameAsync(User.Claims?.FirstOrDefault()?.Value);
            string response = await _perfumeService.Update(value, user.Id);

            return response;
        }

        // DELETE api/<PerfumeController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(Guid id)
        {
            string response = await _perfumeService.Delete(id);
            return response;
        }
    }
}
