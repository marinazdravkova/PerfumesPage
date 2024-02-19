using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Products.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string Country { get; set; } = null!;
    }
}
