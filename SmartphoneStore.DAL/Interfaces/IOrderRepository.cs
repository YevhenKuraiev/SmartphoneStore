using SmartphoneStore.DAL.Entities;
using System.Collections.Generic;

namespace SmartphoneStore.DAL.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
