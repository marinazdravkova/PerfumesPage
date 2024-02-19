using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class CardItem : BaseEntity
    {
        public Guid CardId { get; set; } // Foreign Key

        public virtual Card Card { get; set; } // Navigation property

        public Guid PerfumeId { get; set; } // Foreign Key

        public virtual Perfume Perfume { get; set; } // Navigation property
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; } 

        public decimal TotalPrice { get { return Quantity * Price; } }
    }
}
