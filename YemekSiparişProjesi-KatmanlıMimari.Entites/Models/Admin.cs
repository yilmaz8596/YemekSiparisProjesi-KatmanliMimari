
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Admin : BaseEntity
    {
        // Use nullable reference types or provide default values
        public string? AdminName { get; set; } = string.Empty;
        public string? AdminSurname { get; set; } = string.Empty;
        public string? AdminUserName { get; set; } = string.Empty;
        public string? AdminPassword { get; set; } = string.Empty;
    }
}
