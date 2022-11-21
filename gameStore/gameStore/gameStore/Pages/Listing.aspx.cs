using System;
using System.Collections.Generic;
using gameStore.Models;
using gameStore.Models.Rerository;
using System.Linq;
using gameStore.Pages.Helpers;
using System.Web.Routing;
using gameStore.Models.Repository;

namespace gameStore.Pages
{
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        private int pageSize = 4;

        protected int CurrentPage
        {
            get
            {
                int page;
                page = GetPageFromRequest();
                return page > MaxPage ? MaxPage : page;
            }
        }
        protected int MaxPage
        {
            get
            {
                int prodCount = FilterGames().Count();

                return (int)Math.Ceiling((decimal)prodCount / pageSize);
            }
        }
        private int GetPageFromRequest()
        {
            int page;

            string reqValue = (string)RouteData.Values["page"] ?? Request.QueryString["page"];
            
            return reqValue != null && int.TryParse(reqValue, out page) ? page : 1;
        }
        public IEnumerable<Games> GetGames()
        {
            return FilterGames()
                .OrderBy(g => g.GameID)
                .Skip((CurrentPage - 1) * pageSize)
                .Take(pageSize);
        }
        // Новый вспомогательный метод для фильтрации игр по категориям
        private IEnumerable<Games> FilterGames()
        {
            IEnumerable<Games> games = repository.Games;

            string currentCategory = (string)RouteData.Values["category"] ?? Request.QueryString["category"];

            return currentCategory == null ? games : games.Where(p => p.Category == currentCategory);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedGameID;

                if (int.TryParse(Request.Form["add"], out selectedGameID))
                {
                    Games selectedGame = repository.Games
                        .Where(g => g.GameID == selectedGameID).FirstOrDefault();

                    if (selectedGame != null)
                    {
                        SessionHelper.GetCart(Session).AddItem(selectedGame, 1);
                        SessionHelper.Set(Session, SessionKey.RETURN_URL, Request.RawUrl);

                        Response.Redirect(RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath);
                    }
                }
            }
        }
    }
}