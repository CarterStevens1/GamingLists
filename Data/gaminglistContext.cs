using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace gaminglist.Data
{
    public class gaminglistContext : DbContext
    {
        public gaminglistContext (DbContextOptions<gaminglistContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Game> Game { get; set; }
    }
}
