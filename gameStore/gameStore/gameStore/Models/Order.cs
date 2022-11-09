using System.Collections.Generic;

namespace gameStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Completed { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public Order Order { get; set; }
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }
}