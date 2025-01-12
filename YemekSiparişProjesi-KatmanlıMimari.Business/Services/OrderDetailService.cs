using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class OrderDetailService
    {
        private readonly OrderDetailRepository _orderDetailRepository;
        public OrderDetailService(OrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }
        public OrderDetail GetOrderDetailById(Guid orderID, Guid dishID)
        {
            return _orderDetailRepository.GetOrderDetailByID(orderID, dishID);
        }
        public void Add(OrderDetail orderDetail)
        {
            OrderValidator validator = new();
            ValidationResult result = validator.Validate(orderDetail);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _orderDetailRepository.Add(orderDetail);
        }
        public void Update(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }
        public void Delete(Guid orderId, Guid dishID)
        {
            _orderDetailRepository.DeleteOrderDetail(orderId, dishID);
        }
        public bool IfOrderDetailExists(Guid orderId, Guid dishID)
        {
            return _orderDetailRepository.IfEntityExists(od => od.OrderID == orderId && od.DishID == dishID);
        }
    }
    

}
