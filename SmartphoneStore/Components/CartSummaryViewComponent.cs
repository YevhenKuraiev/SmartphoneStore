using Microsoft.AspNetCore.Mvc;
using SmartphoneStore.BLL.BusinessModels;

namespace SmartphoneStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService) => cart = cartService;
        public IViewComponentResult Invoke() => View(cart);
    }
}
