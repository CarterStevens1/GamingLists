using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gaminglist.Pages.Games;
using System;
using System.Linq;
using gaminglist.Data;

namespace gaminglist.Pages.Games
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new gaminglistContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<gaminglistContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                 
                    new Game
                    {
                        Title = "Borderlands",
                        Genre = "Action",
                        Rating = "18",
                       


                    }
                );
                context.SaveChanges();
            }
        }
    }
}