using SmartphoneStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartphoneStore.DAL.Entities
{
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
