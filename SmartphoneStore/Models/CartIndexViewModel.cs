using SmartphoneStore.BLL.BusinessModels;
using SmartphoneStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
