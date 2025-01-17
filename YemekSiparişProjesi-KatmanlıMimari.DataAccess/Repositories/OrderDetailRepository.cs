using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<OrderDetail> _dbSet;
        public OrderDetailRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
            _dbSet=_dbContext.Set<OrderDetail>();
        }


        public void DeleteOrderDetail(Guid OrderID, Guid DishID)
        {
            var orderDetail = _dbSet.FirstOrDefault(x => x.OrderID == OrderID && x.DishID == DishID);

            if (orderDetail != null)
            {
                _dbSet.Remove(orderDetail);
                _dbContext.SaveChanges();
            }
        }
        public OrderDetail GetOrderDetailByID(Guid orderId, Guid DishID)
        {
            var orderDetail = _dbSet.FirstOrDefault(x => x.OrderID == orderId && x.DishID == DishID);

            if (orderDetail != null)
            {
                return orderDetail;
            }

            throw new Exception("Sipariş detayı bulunamadı");

        }
    }
}
