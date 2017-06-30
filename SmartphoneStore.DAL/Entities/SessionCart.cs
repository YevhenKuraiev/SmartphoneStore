using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SmartphoneStore.DAL.Entities
{
    public class SessionCart : Cart
    {
        //public static Cart GetCart(IServiceProvider services)
        //{
        //    ISession session = services.GetRequiredService<IHttpContextAccessor>()?
        //        .HttpContext.Session;

        //    SessionCart cart = session?.GetJson<SessionCart>("Cart");

        //    return Cart;
        //}
    }
}
