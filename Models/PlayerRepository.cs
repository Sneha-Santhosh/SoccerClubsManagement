using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class PlayerRepository
    {
        private static List<PlayerResponse> playerResponses = new List<PlayerResponse>();
        public static IEnumerable<PlayerResponse> PlayerResponses
        {
            get
            {
                return playerResponses;
            }
        }       
        public static void AddResponse(PlayerResponse playerResponse)
        {
            playerResponses.Add(playerResponse);
        }      
    }
}
