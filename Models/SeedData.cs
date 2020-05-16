using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Clubs.Any())
            {
                context.Clubs.AddRange(
                    new ClubResponse { ClubName = "Barcelona", Location = "Spain", ManagerName = "Quique Setién" },
                    new ClubResponse { ClubName = "Real Madrid", Location = "Spain", ManagerName = "Zenedin Zidan" },
                    new ClubResponse { ClubName = "Manchester",  Location = "England", ManagerName = "Ole Gunnar" },
                    new ClubResponse { ClubName = "Chelsea", Location = "England", ManagerName = "Fernand Russo" },
                    new ClubResponse { ClubName = "Atletico Madrid", Location = "Spain", ManagerName = "Mark Pablo" },
                    new ClubResponse { ClubName = "CSKA", Location = "Russia", ManagerName = "Vladimir Kuznecov" },
                    new ClubResponse { ClubName = "Milan", Location = "Italia", ManagerName = "Fresco Pate" },
                    new ClubResponse { ClubName = "Blasters", Location = "Kerala", ManagerName = "Mohanlal" });
                context.SaveChanges();
            }
        }
    }
}
        
