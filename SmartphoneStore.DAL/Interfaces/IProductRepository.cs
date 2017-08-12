using SmartphoneStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
