using Products.Application.Common.Helpers;
using Products.Application.Common.Models;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<ResponseModel> Register(RegisterModelDto model); //Task zatoa sto metodot sakame da e asinhron(nezavisno fukncionira eden od drug)

        Task<SignInResponse> SignIn(SignInModelDto model);

        Task<ApplicationUser> GetUserByUserName(string userName);
    }
}
