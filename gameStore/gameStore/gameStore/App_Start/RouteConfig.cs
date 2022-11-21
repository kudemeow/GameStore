using Microsoft.AspNet.FriendlyUrls;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;

namespace gameStore
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // надо
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");

            //корзина
            routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");

            //оформление заказа
            routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");

            // Новые маршруты для административных страниц
            routes.MapPageRoute("admin_orders", "admin/orders", "~/Pages/Admin/Orders.aspx");
            routes.MapPageRoute("admin_games", "admin/games", "~/Pages/Admin/Games.aspx");

            // не надо
            //routes.MapPageRoute(null, "Pages/Listing", "~/Pages/Listing.aspx");
            //routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            ////routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            //routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            ////routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");
        }
    }
}
