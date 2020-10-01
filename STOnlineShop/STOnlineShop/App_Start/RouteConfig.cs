using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace STOnlineShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
           name: "Detail",
           url: "chi-tiet/{productId}",
           defaults: new { controller = "Products", action = "Detail", id = UrlParameter.Optional }
       );

            routes.MapRoute(
          name: "AddCart",
          url: "gio-hang",
          defaults: new { controller = "Cart", action = "AddItem", id = UrlParameter.Optional }
      );
            routes.MapRoute(
         name: "Cart",
         url: "gio-hang-",
         defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
     );

            routes.MapRoute(
         name: "Payment",
         url: "thanh-toan",
         defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional }
     );

            routes.MapRoute(
        name: "PaymentSuccess",
        url: "hoan-thanh",
        defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional }
    );


            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "TrangChu", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
         name: "Adidas",
         url: "{controller}/{action}/{id}",
         defaults: new { controller = "Products", action = "brand3", id = UrlParameter.Optional }
     );
            routes.MapRoute(
         name: "Fila",
         url: "{controller}/{action}/{id}",
         defaults: new { controller = "Products", action = "brand2", id = UrlParameter.Optional }
     );
            routes.MapRoute(
        name: "Nike",
        url: "{controller}/{action}/{id}",
        defaults: new { controller = "Products", action = "brand1", id = UrlParameter.Optional }
    );

            routes.MapRoute(
           name: "Shop",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Products", action = "Shop", id = UrlParameter.Optional }
       );

            routes.MapRoute(
          name: "Sale",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Products", action = "Sale", id = UrlParameter.Optional }
      );




            routes.MapRoute(
             name: "Login",
             url: "Admin/{controller}/{action}/{id}",
             defaults: new { controller = "Login", action = "login", id = UrlParameter.Optional }
         );


           
           

        }
    }
}
