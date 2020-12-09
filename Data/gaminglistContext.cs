using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gaminglist.Pages.Games;

namespace gaminglist.Data
{
    public class gaminglistContext : DbContext
    {
        public gaminglistContext (DbContextOptions<gaminglistContext> options)
            : base(options)
        {
        }

        public DbSet<gaminglist.Pages.Games.Game> Game { get; set; }
    }
}
