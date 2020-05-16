using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class FakeClubRepository//:IClubRepository
    {

        private List<ClubResponse> clubResponses = new List<ClubResponse>();
        
            
        public void AddResponse(ClubResponse clubResponse)
        {
            clubResponses.Add(clubResponse);
        }
        public  IQueryable<ClubResponse> Clubs
        {
            get
            {
                return clubResponses.AsQueryable<ClubResponse>();
            }
        }

      
    }
}
