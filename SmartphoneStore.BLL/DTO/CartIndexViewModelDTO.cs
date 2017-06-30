using SmartphoneStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.BLL.DTO
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
