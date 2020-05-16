using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public interface IClubRepository
    {
        IQueryable<ClubResponse> Clubs { get;  }
       // void AddResponse(ClubResponse clubResponse);
        void SaveClub(ClubResponse club);
        void AddNewClub(ClubResponse club);
        ClubResponse DeleteClub(ClubResponse club);
    }
}
