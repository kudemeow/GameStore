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
            if (order.OrderID == 0)
            {
                order = context.Orders.Add(order);

                foreach (OrderLine line in order.OrderLines)
                {
                    context.Entry(line.Game_GameID).State = EntityState.Modified;
                }

            }
            else
            {
                Order dbOrder = context.Orders.Find(order.OrderID);

                if (dbOrder != null)
                {
                    dbOrder.Name = order.Name;
                    dbOrder.Email = order.Email;
                    dbOrder.Completed = order.Completed;
                }
            }
            context.SaveChanges();
        }
    }
}