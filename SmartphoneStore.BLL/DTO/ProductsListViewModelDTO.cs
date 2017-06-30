using SmartphoneStore.DAL.Entities;
using System.Collections.Generic;

namespace SmartphoneStore.BLL.DTO
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
