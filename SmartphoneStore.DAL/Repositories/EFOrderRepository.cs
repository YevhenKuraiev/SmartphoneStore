using SmartphoneStore.DAL.Interfaces;
using System.Collections.Generic;
using SmartphoneStore.DAL.Entities;
using SmartphoneStore.DAL.EF_Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SmartphoneStore.DAL.Repositories
{
    public class EFOrderRepository : IOrderRepository
    {
        private ApplicationDbContext context;
        public EFOrderRepository(ApplicationDbContext ctx) => context = ctx;
        public IEnumerable<Order> Orders => context.Orders.Include(o => o.Lines).ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0) context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}
