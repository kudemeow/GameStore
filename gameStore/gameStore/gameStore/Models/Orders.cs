using System.Collections.Generic;

namespace gameStore.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public string Name { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public Orders Order { get; set; }
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }
}