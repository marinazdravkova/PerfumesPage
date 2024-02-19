using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class Brand : BaseEntity
    {
        
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? Country { get; set; }

        public ICollection<Perfume>? Perfumes { get; set; }
    }
}
