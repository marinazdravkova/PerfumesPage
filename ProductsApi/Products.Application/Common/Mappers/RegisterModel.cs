using Products.Application.Common.Models;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Common.Mappers
{
    public static class RegisterModel
    {
        public static ApplicationUser ToApplicationUser(this RegisterModelDto registerModel)
        {
            return new ApplicationUser()
            {
                Country = registerModel.Country,
                Email = registerModel.Email,
                UserName = registerModel.Username
                //pasvordot ne se mapira zatoa sto e hesiran, pasvordot ke go napravi Asp.NetCore Identity
            };

        }
    }
}
