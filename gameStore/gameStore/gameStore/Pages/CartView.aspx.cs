using System;
using System.Collections.Generic;
using System.Linq;
using gameStore.Models;
using gameStore.Models.Rerository;
using gameStore.Pages.Helpers;

namespace gameStore.Pages
{
    public partial class CartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Repository repository = new Repository();

                int gameID;

                if (int.TryParse(Request.Form["remove"], out gameID))
                {
                    Game gameToRemove = repository.Games
                        .Where(g => g.GameID == gameID).FirstOrDefault();

                    if (gameToRemove != null)
                    {
                        SessionHelper.GetCart(Session).RemoveLine(gameToRemove);
                    }
                }
            }
        }
        public IEnumerable<CartLine> GetCartLines()
        {
            return SessionHelper.GetCart(Session).Lines;
        }
        public decimal CartTotal
        {
            get
            {
                return (decimal)SessionHelper.GetCart(Session).ComputeTotalValue();
            }
        }
        public string ReturnUrl
        {
            get
            {
                return SessionHelper.Get<string>(Session, SessionKey.RETURN_URL);
            }
        }
    }
}