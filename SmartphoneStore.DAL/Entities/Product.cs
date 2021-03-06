﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartphoneStore.DAL.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Введите наименование товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Введите описание")]
        public string Description { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Введите положительное значение для цены")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Укажите категорию")]
        public string Category { get; set; }
    }
}
