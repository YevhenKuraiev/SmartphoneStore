using SmartphoneStore.BLL.BusinessModels;
using SmartphoneStore.DAL.Entities;
using System.Collections.Generic;

namespace SmartphoneStore.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
