using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
   public interface IPlayerRepository
    {
        IQueryable<PlayerResponse> Players { get; }
        // void AddResponse(ClubResponse clubResponse);
        void SavePlayer(PlayerResponse player);
    }
}
