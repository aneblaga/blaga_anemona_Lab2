using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using blaga_anemona_Lab2ok.Data;
using blaga_anemona_Lab2ok.Models;

namespace blaga_anemona_Lab2ok.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext _context;

        public DetailsModel(blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
