using gameStore.Models.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace gameStore.Models.Rerository
{
    public class Repository
    {
        public IEnumerable<Games> Games => gameStoreEntities.GetContext().Games;
        public IEnumerable<Orders> Orders => gameStoreEntities.GetContext().Orders.Include(o => o.OrderLines.Select(ol => ol.Game_GameID));

        // Сохранить данные заказа в базе данных
        public void SaveOrder(Orders order)
        {
            //Order currOrder = context.Orders.Find(order.OrderID);

            //if (currOrder == null)
            //{
            //    Order dbOrder = new Order()
            //    {
            //        Name = order.Name,
            //        Email = order.Email,
            //        Completed = order.Completed
            //    };


            gameStoreEntities.GetContext().Orders.Add(order);
            //context.OrderLines.AddRange(order.OrderLines);
            gameStoreEntities.GetContext().SaveChanges();
            //}
        }
    }
}