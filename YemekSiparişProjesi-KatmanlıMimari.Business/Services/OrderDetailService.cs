using FluentValidation;
using Microsoft.EntityFrameworkCore;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

public class OrderDetailService
{
    private readonly OrderDetailRepository _orderDetailRepository;
    private readonly DishRepository _dishRepository;
    private readonly OrderRepository _orderRepository;


    public OrderDetailService(
        OrderDetailRepository orderDetailRepo,
        DishRepository dishRepository,
        OrderRepository orderRepository)
    {
        _orderDetailRepository = orderDetailRepo ?? throw new ArgumentNullException(nameof(orderDetailRepo));
        _dishRepository = dishRepository ?? throw new ArgumentNullException(nameof(dishRepository));
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
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
            var dish = _dishRepository.GetById(orderDetail.DishID);
            if (dish == null)
            {
                throw new ArgumentException($"Yemek bulunamadı. DishID: {orderDetail.DishID}");
            }

            var order = _orderRepository.GetById(orderDetail.OrderID);
            if (order == null)
            {
                throw new ArgumentException($"Sipariş bulunamadı. OrderID: {orderDetail.OrderID}");
            }

            orderDetail.UnitPrice = dish.UnitPrice;

            _orderDetailRepository.Add(orderDetail);
        }
        catch (DbUpdateException dbEx)
        {
            string errorMessage = "Sipariş detayı eklenirken hata oluştu.";
            if ((bool)(dbEx.InnerException?.Message.Contains("FK_OrderDetails_Dishes_DishID")))
            {
                errorMessage = "Belirtilen yemek sistemde bulunamadı.";
            }
            throw new Exception(errorMessage, dbEx);
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