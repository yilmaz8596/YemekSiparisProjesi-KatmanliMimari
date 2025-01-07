using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class User : BaseEntity
    {
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? FullName => $"{UserName} {UserSurname}";
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
