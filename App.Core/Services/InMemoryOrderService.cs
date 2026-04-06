using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{


    public class InMemoryOrderService : IOrderService
    {
        private List<Order> _orders;
        public InMemoryOrderService()
        {
            _orders = new List<Order>();
        }

        List<Order> IOrderService.GetAll()
        {
            return _orders.ToList();
        }
        void IOrderService.Add(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Order is null");
            _orders.Add(order);
        }
        void IOrderService.Delete(Order order)
        {
            _orders.RemoveAll(order => order.Id == order.Id);
        }

        List<Order> IOrderService.GetCustomerById(string customerId)
        {
            return _orders.Where(order => order.CustomerId == customerId).ToList();
        }

        Order IOrderService.GetById(string id)
        {
            return _orders.FirstOrDefault(order => order.Id == id);
        }

        List<Order> IOrderService.GetByStatus(OrderStatusEnum status)
        {
        return _orders.Where(order => order.Status == status).ToList();
        }

        void IOrderService.Update(Order order)
        {
            var existing = _orders.FirstOrDefault(o => o.Id == order.Id);
            if (existing == null)
            {
                throw new Exception($"Order with Id={order.Id} not found");
            }
            existing.CustomerId = order.CustomerId;
            existing.CustomerName = order.CustomerName;
            existing.OrderDate = order.OrderDate;
            existing.Items = order.Items;
            existing.Status = order.Status;
            existing.PaymentMethod = order.PaymentMethod;
        }
        

        /*
         * InMemoryOrderService orderService = new InMemoryOrderService();
         * orderService.GetAll(); NOT Allowed
         * 
         * 
         * IOrderService orderService = new InMemoryOrderService();
         * orderService.GetAll();
         * */
    }
}