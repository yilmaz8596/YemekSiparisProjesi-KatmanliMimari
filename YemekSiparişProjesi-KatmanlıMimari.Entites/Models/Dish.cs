using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Dish : BaseEntity
    {
        public string? DishName { get; set; } 
        public string? Description { get; set; } 
        public decimal UnitPrice { get; set; } 
        public string? ImageUrl { get; set; }
        public int CategoryID { get; set; } // Yemeklerin kategoriye göre ayrılması için
        public ICollection<OrderDetail>? OrderDetails { get; set; } // Bir yemek birden fazla sipariş detayına sahip olabilir.
    }
}
