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
    public class IndexModel : PageModel
    {
        private readonly blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext _context;

        public IndexModel(blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
            }
        }
    }
}
