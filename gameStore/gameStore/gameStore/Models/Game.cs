using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gameStore.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Poster { get; set; }
        public string Category { get; set; }
    }
}