using gameStore.Models.Repository;
using System;
using System.Data.SqlClient;
using System.Web.Routing;
using System.Web.UI;

namespace gameStore.Pages
{
    public partial class Store : MasterPage
    {
        protected void SearchGame(object sender, EventArgs e)
        {
            var searchGameByName = Request.Form["searchGame"].ToLower();
            string currentCategory = Request.QueryString["category"];


            string path = RouteTable.Routes.GetVirtualPath(null, null,
                new RouteValueDictionary() { { "name", searchGameByName }, { "page", "1" }, { "category", currentCategory} }).VirtualPath;

            Response.Redirect(path);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}