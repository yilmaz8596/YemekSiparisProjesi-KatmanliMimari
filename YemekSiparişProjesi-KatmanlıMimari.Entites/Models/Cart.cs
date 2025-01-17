using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;
using System.Collections.Generic;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Cart : BaseEntity
    {
        public Guid UserID { get; set; }
        public User? User { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
    }

    public class CartItem : BaseEntity
    {
        public Guid CartID { get; set; }
        public Cart? Cart { get; set; }
        public Guid OrderID { get; set; }
        public Order? Order { get; set; }
        public Guid DishID { get; set; }
        public Dish? Dish { get; set; }
        public int Quantity { get; set; }
    }
}