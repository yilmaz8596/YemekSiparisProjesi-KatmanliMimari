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
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
        public Order? Order { get; set; }
        public Dish? Dish { get; set; }
        public Guid OrderID { get; set; }
        public Guid DishID { get; set; }
    }
}
