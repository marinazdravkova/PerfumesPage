using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Entities.Enums;

namespace Products.Entities
{
    public class Perfume : BaseEntity
    {
     
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public string? PerfumeType { get; set; }
        public string? Season { get; set; }
        public string ImageURL { get; set; } = null!;

        [ForeignKey("BrandId")]
        public Guid BrandId { get; set; }
        public virtual Brand? Brand { get; set; }




    }
}
