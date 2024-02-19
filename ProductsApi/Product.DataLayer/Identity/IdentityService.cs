using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Products.Application.Common.Helpers;
using Products.Application.Common.Interfaces;
using Products.Application.Common.Mappers;
using Products.Application.Common.Models;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> _roleManager;
        public IdentityService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _roleManager = roleManager;
        }
        public async Task<ApplicationUser> GetUserByUserName(string userName)
        {
            return await _userManager.FindByNameAsync(userName);
        }

        public async Task<ResponseModel> Register(RegisterModelDto model)
        {
            
            ApplicationUser user = RegisterModel.ToApplicationUser(model); //Koga se prima dto prvo se mapira vo user za da se zapise vo baza

            var validationModel = await Validate(model, user);

            if (validationModel.isValid)
            {
                IdentityResult identityResult = await _userManager.CreateAsync(user, model.Password);

                if (identityResult.Errors.Any())
                {
                    var errors = "";

                    foreach (var item in identityResult.Errors)
                    {
                        errors += item.Description + ";";
                    }
                    return new ResponseModel()
                    {
                        isValid = false,
                        ResponseMessage = errors
                    };
                }
                
                return new ResponseModel()
                {
                    isValid = true,
                    ResponseMessage = "OK"
                };
            }

            else
            {
                return new ResponseModel()
                {
                    isValid = false,
                    ResponseMessage = validationModel.ResponseMessage
                };
            }

        }

        public async Task<SignInResponse> SignIn(SignInModelDto model)
        {
            //Validation method for sign in
            var signInResult = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);

            if (signInResult.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                
                var claims = new Claim[]
               {
                   new Claim(ClaimTypes.NameIdentifier,user.UserName),
                    //new Claim(ClaimTypes.Role,roles[0]),
                    new Claim(ClaimTypes.Country,user.Country)
               };

                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("SecretKey")));

                var signinCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(signingCredentials: signinCredentials, expires: DateTime.UtcNow.AddHours(1), claims: claims);

                return new SignInResponse
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Username = user.UserName
                };


            }

            else
            {
                return new SignInResponse
                {
                    Token = string.Empty,
                    Username = string.Empty
                };
            }
        }
        private async Task<ResponseModel> Validate(RegisterModelDto model, ApplicationUser user)
        {
            if (string.IsNullOrEmpty(model.Email) ||
                string.IsNullOrEmpty(model.Password) ||
                string.IsNullOrEmpty(model.Country) ||
                 string.IsNullOrEmpty(model.ConfirmPassword) ||
                 string.IsNullOrEmpty(model.Username))
            {
                return new ResponseModel()
                {
                    isValid = false,
                    ResponseMessage = "Registration failed!"
                };
            }



            var email = await _userManager.FindByEmailAsync(model.Email);

            if (email != null)
            {
                return new ResponseModel()
                {
                    isValid = false,
                    ResponseMessage = "Email exist!"
                };
            }

            var existingUser = await _userManager.FindByNameAsync(model.Username);

            if (existingUser != null)
            {
                return new ResponseModel()
                {
                    isValid = false,
                    ResponseMessage = "Username exist!"
                };
            }

            if (model.Password != model.ConfirmPassword)
            {
                return new ResponseModel()
                {
                    isValid = false,
                    ResponseMessage = "Password and Confirm Password doesnt match"
                };
            }

            return new ResponseModel()
            {
                isValid = true,
                ResponseMessage = "OK"
            };

        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        public async Task<IdentityResult> AddRole(string role)
        {
            return await _roleManager.CreateAsync(new IdentityRole() { Name = role });
        }

    }
    
}
