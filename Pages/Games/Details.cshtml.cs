using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using gaminglist.Data;

namespace gaminglist.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly gaminglist.Data.gaminglistContext _context;

        public DetailsModel(gaminglist.Data.gaminglistContext context)
        {
            _context = context;
        }

        public Game game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
