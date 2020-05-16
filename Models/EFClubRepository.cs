using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class EFClubRepository : IClubRepository
    {
        private ApplicationDbContext context;
        public EFClubRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<ClubResponse> Clubs => context.Clubs;

        public void AddNewClub(ClubResponse club)
        {

             context.Clubs.Add(club);
            context.SaveChanges();

        }
        public void SaveClub(ClubResponse club) 
        { if (club.ClubID == 0) 
            {
                context.Clubs.Add(club); 
            } 
            else
            {
                ClubResponse dbEntry = context.Clubs.FirstOrDefault(p => p.ClubID == club.ClubID);
                if (dbEntry != null)
                { 
                    dbEntry.ClubName = club.ClubName;
                    dbEntry.ManagerName = club.ManagerName;
                    dbEntry.Location = club.Location;
                   } 
            }
            context.SaveChanges();
        }
        public ClubResponse DeleteClub(ClubResponse club)
        {
            ClubResponse dbEntry = context.Clubs.FirstOrDefault(p => p.ClubID == club.ClubID);
            if (dbEntry != null)
            {
                context.Clubs.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
