using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gameStore.Models.Rerository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }
    }
}