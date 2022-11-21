using System;
using System.Collections.Generic;
using gameStore.Models;
using gameStore.Pages.Helpers;
using System.Web.ModelBinding;
using gameStore.Models.Repository;
using gameStore.Models.Rerository;

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

                Orders myOrder = new Orders();

                if (TryUpdateModel(myOrder, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    myOrder.OrderLines = new List<OrderLines>();

                    Cart myCart = SessionHelper.GetCart(Session);

                    foreach (CartLine line in myCart.Lines)
                    {
                        myOrder.OrderLines.Add(new OrderLines
                        {
                            Orders = myOrder,
                            //Order_OrderID = myOrder.OrderID,
                            Games = line.Game,
                            //Game_GameID = line.Game.GameID,
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