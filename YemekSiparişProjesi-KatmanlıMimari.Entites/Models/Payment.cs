using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Models
{
    public enum PaymentStatus
    {
        Pending,
        Successful,
        Failed,
        Refunded
    } // ödeme durumları enum olarak tanımlandı
    public class Payment : BaseEntity
    {
        public string? PaymentType { get; set; }
        public string? PaymentAmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public Order? Order { get; set; }
        public Guid OrderID { get; set; } // her sipraişin bir ödemesi olacağı için. 1'e 1 ilişki
    }
}
