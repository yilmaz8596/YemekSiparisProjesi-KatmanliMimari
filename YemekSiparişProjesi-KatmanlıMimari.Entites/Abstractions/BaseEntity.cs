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
        }
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
