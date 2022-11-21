using gameStore.Models.Repository;
using gameStore.Models.Rerository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gameStore.Pages.Admin
{
    public partial class Orders : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int completeID;
                if (int.TryParse(Request.Form["dispatch"], out completeID))
                {
                    Orders myOrder = repository.Orders.Where(o => o.OrderID == completeID).FirstOrDefault();
           
                    if (myOrder != null)
                    {
                        myOrder.Completed = true;
                        repository.SaveOrder(myOrder);
                    }
                }
            }
        }

        public IEnumerable<Orders> GetOrders([Control] bool showDispatched)
        {
            if (showDispatched)
            {
                return (IEnumerable<Orders>)repository.Orders;
            }
            else
            {
                return repository.Orders.Where(o => !o.Dispatched);
            }
        }

        public decimal Total(IEnumerable<OrderLines> orderLines)
        {
            decimal total = 0;
            foreach (OrderLines ol in orderLines)
            {
                total += ol.Games.Price * ol.Quantity;
            }
            return total;
        }
    }
}