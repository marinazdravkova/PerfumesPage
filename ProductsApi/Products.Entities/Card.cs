using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    public class Card : BaseEntity
    {
        public virtual ICollection<CardItem> Items { get; set; } // Navigation property
        [NotMapped]
        public decimal TotalPrice => Items?.Sum(i => i.TotalPrice) ?? 0 ; // Calculated property

        public bool IsConfirmed { get; set; }
    }
}
