using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
  public static class ClubRepository
    {
        private static List<ClubResponse> clubResponses = new List<ClubResponse>();
        public static IEnumerable<ClubResponse> ClubResponse
        {
            get
            {
                return clubResponses;   
            }
        }
        public static void AddResponse(ClubResponse clubResponse)
        {
             clubResponses.Add(clubResponse);
         }
     }
 }

