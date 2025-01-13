using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Category : BaseEntity
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }

        public string? CategoryImage { get; set; }
        public ICollection<Dish>? Dishes { get; set; }
    }
}
