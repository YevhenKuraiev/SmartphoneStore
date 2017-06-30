using Moq;
using SmartphoneStore.Components;
using SmartphoneStore.Models;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

namespace SmartphoneStore.Tests
{
    public class NavigationMenuViewComponentTests
    {
        [Fact]
        public void Can_Select_Categories()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1", Category = "Смартфоны"},
                new Product {ProductID = 2, Name = "P2", Category = "Смартфоны"},
                new Product {ProductID = 3, Name = "P3", Category = "Компьютеры"},
                new Product {ProductID = 4, Name = "P4", Category = "Ноутбуки"}
            });

            NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);

            string[] results = ((IEnumerable<string>)(target.Invoke() 
                as ViewViewComponentResult).ViewData.Model).ToArray();

            Assert.True(Enumerable.SequenceEqual(new string[] { "Компьютеры",  "Ноутбуки", "Смартфоны" }, results));
        }

        [Fact]
        public void Indicates_Selected_Category()
        {
            string categoryToSelect = "Смартфоны";
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[] {
                new Product {ProductID = 1, Name = "P1", Category = "Смартфоны"},
                new Product {ProductID = 4, Name = "P2", Category = "Ноутбуки"}
            });

            NavigationMenuViewComponent target = new NavigationMenuViewComponent(mock.Object);
            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new RouteData()
                }
            };
            target.RouteData.Values["category"] = categoryToSelect;

            string results = (string)(target.Invoke()
                as ViewViewComponentResult).ViewData["SelectedCategory"];

            Assert.Equal(categoryToSelect, results);
        }
    }
}
