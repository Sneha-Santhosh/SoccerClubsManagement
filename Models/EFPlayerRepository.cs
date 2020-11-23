using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class EFPlayerRepository:IPlayerRepository
    {
        private ApplicationDbContext context;
        public EFPlayerRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<PlayerResponse> Players => context.Players;
        public void SavePlayer(PlayerResponse player)
        {
            context.Players.Add(player);
            context.SaveChanges();
        }
    }
}
