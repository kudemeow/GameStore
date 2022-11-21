using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gameStore.Pages.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public string OrdersUrl => GenerateURL("admin_orders");
        public string GamesUrl => GenerateURL("admin_games");
        private string GenerateURL(string routeName) => RouteTable.Routes.GetVirtualPath(null, routeName, null).VirtualPath;
    }
}