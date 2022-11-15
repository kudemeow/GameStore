using System;
using System.Collections.Generic;
using gameStore.Models;
using gameStore.Models.Rerository;
using gameStore.Pages.Helpers;
using System.Web.ModelBinding;

namespace gameStore.Pages
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkoutForm.Visible = true;
            checkoutMessage.Visible = false;

            if (IsPostBack)
            {
                var name = Request.Form["ctl00$bodyContent$name"];
                var email = Request.Form["ctl00$bodyContent$email"];

                Order myOrder = new Order();

                if (TryUpdateModel(myOrder, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    myOrder.OrderLines = new List<OrderLine>();

                    Cart myCart = SessionHelper.GetCart(Session);

                    foreach (CartLine line in myCart.Lines)
                    {
                        myOrder.OrderLines.Add(new OrderLine
                        {
                            Order = myOrder,
                            Order_OrderID = myOrder.OrderID,
                            Game = line.Game,
                            Game_GameID = line.Game.GameID,
                            Quantity = line.Quantity
                        });
                    }

                    myOrder.Name = name;
                    myOrder.Email = email;
                    myOrder.Completed = true;

                    new Repository().SaveOrder(myOrder);
                    myCart.Clear();

                    checkoutForm.Visible = false;
                    checkoutMessage.Visible = true;
                }
            }
        }
    }
}