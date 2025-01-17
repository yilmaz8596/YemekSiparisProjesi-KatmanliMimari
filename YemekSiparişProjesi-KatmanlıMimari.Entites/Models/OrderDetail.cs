using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderID { get; set; }
        public Guid DishID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Order? Order { get; set; }
        public virtual Dish? Dish { get; set; }
    }
}
