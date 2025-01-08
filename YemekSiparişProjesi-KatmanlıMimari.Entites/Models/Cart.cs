
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Cart : BaseEntity
    {
        public Guid UserID { get; set; } // BaseEntity'den gelen Id'yi User'a çevirdik.
        public int OrderID { get; set; }
        public User? User { get; set; }
        public Order? Order { get; set; } // Order'ı burada tanımladık.

    }
}
