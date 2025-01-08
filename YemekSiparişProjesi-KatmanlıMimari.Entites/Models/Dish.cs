using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Dish : BaseEntity
    {
        public string? DishName { get; set; } 
        public string? Description { get; set; } 
        public decimal UnitPrice { get; set; } 
        public string? ImageUrl { get; set; }
        public Category? Categories { get; set; }
        public Guid CategoryID   { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; } // Bir yemek birden fazla sipariş detayına sahip olabilir.
    }
}
