using Microsoft.AspNetCore.Mvc.ModelBinding;
using SmartphoneStore.DAL.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartphoneStore.BLL.DTO
{
    public class OrderViewModel
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public IEnumerable<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите адрес")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Введите город")]
        public string City { get; set; }

        [Required(ErrorMessage = "Введите страну")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
