using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparişProjesi_KatmanlıMimari.Entites.Abstractions
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            ID= Guid.NewGuid();
            CreateDate = DateTime.Now; // Bağımsız zaman dilimi
            IsActive = true; // Default olarak true
        }
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; } // Opsiyonel olarak güncelleme tarihi
        public Guid? CreatedBy { get; set; } // Oluşturan kişi
        public Guid? ModifiedBy { get; set; } // Düzenleyen kişi

    }
}
