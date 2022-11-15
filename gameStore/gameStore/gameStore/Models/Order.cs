using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gameStore.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        //[Required(ErrorMessage = "Пожалуйста введите свое имя")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Пожалуйста укажите свой адрес электронной почты")]
        public string Email { get; set; }
        public bool Completed { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineID { get; set; }
        public int Order_OrderID { get; set; }
        public Order Order { get; set; }
        public int Game_GameID { get; set; }
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }
}