using SmartphoneStore.DAL.EF_Core;
using SmartphoneStore.DAL.Entities;
using SmartphoneStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.DAL.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Product> Products => context.Products;
    }
}
