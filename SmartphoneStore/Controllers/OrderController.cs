using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartphoneStore.DAL.Entities;
using SmartphoneStore.BLL.DTO;
using SmartphoneStore.DAL.Interfaces;
using SmartphoneStore.BLL.BusinessModels;

namespace SmartphoneStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        [HttpGet]
        public ViewResult Checkout() => View(new OrderViewModel());

        [HttpPost]
        public IActionResult Checkout(OrderViewModel orderView)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "������� �����!");
            }
            if (ModelState.IsValid)
            {
                Order order = new Order
                {
                    OrderID = orderView.OrderID,
                    Address = orderView.Address,
                    City = orderView.City,
                    Country = orderView.Country,
                    GiftWrap = orderView.GiftWrap,
                    Lines = orderView.Lines,
                    Name = orderView.Name
                };
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(orderView);
            }
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}