﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using gameStore.Models;
using gameStore.Models.Repository;

namespace gameStore.Models
{
    public class CartLine
    {
        public Games Game { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public void AddItem(Games game, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Game.GameID == game.GameID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Game = game,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Games game)
        {
            lineCollection.RemoveAll(l => l.Game.GameID == game.GameID);
        }

        public double ComputeTotalValue()
        {
            return (double)lineCollection.Sum(e => e.Game.Price * e.Quantity);

        }
        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }
}