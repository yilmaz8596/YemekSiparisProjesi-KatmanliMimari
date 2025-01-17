using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
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
        private readonly OrderDetailValidator _validator;

        public OrderDetailService(OrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
            _validator = new OrderDetailValidator();
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
            try
            {
                // Ensure required fields are set
                if (orderDetail.OrderID == Guid.Empty)
                {
                    throw new ArgumentException("OrderID must be set");
                }
                if (orderDetail.DishID == Guid.Empty)
                {
                    throw new ArgumentException("DishID must be set");
                }

                // Use the repository to add the order detail to the database
                _orderDetailRepository.Add(orderDetail);
            }
            catch (DbUpdateException dbEx)
            {
                // Provide more detailed error message
                string errorMessage = $"Error adding order detail: {dbEx.Message}";
                if (dbEx.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {dbEx.InnerException.Message}";
                }
                throw new Exception(errorMessage, dbEx);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                string errorMessage = $"Error adding order detail: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                throw new Exception(errorMessage, ex);
            }
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
