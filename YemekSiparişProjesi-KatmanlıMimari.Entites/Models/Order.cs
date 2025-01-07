using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public Decimal TotalAmount { get; set; }
        public User? User { get; set; }
        public Guid UserID { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
