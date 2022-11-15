using gameStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace gameStore.Pages.Helpers
{
    public enum SessionKey
    {
        CART,
        RETURN_URL,
        CHECKOUT
    }
    public class SessionHelper
    {
        public static void Set(HttpSessionState session, SessionKey key, object value)
        {
            session[Enum.GetName(typeof(SessionKey), key)] = value;
        }

        public static T Get<T>(HttpSessionState session, SessionKey key) where T : class
        {
            object dataValue = session[Enum.GetName(typeof(SessionKey), key)];

            return dataValue as T;
        }

        public static Cart GetCart(HttpSessionState session)
        {
            Cart myCart = Get<Cart>(session, SessionKey.CART);

            if (myCart == null)
            {
                myCart = new Cart();
                Set(session, SessionKey.CART, myCart);
            }

            return myCart;
        }

        public static Checkout GetCheckout(HttpSessionState session)
        {
            Checkout checkout = Get<Checkout>(session, SessionKey.CHECKOUT);

            if (checkout == null)
            {
                checkout = new Checkout();
                Set(session, SessionKey.CHECKOUT, checkout);
            }

            return checkout;
        }
    }
}