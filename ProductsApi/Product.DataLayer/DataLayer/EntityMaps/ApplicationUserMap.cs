using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.DataLayer.EntityMaps
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var user = new ApplicationUser()
            {
                Id = "97f5408f-c70b-46cb-9fcb-e32c4e5a3d1c",
                Country = "Macedonia",
                Email = "test@test.com",
            };

            builder.HasData(user);
        }
    }
}
