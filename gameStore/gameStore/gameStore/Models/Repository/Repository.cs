using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace gameStore.Models.Rerository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games => context.Games;
        public IEnumerable<Order> Orders => context.Orders.Include(o => o.OrderLines.Select(ol => ol.Game_GameID));

        // Сохранить данные заказа в базе данных
        public void SaveOrder(Order order)
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


            var lines = order.OrderLines;
            order.OrderLines = null;
            context.Orders.Add(order);
            //context.OrderLines.AddRange(order.OrderLines);
            context.SaveChanges();
            lines.ForEach(x =>
            {
                x.Order_OrderID = order.OrderID;
            });
            context.OrderLines.AddRange(lines);
            context.SaveChanges();
            //}
        }
    }
}