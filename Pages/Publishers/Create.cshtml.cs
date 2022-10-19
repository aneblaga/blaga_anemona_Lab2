using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using blaga_anemona_Lab2ok.Data;
using blaga_anemona_Lab2ok.Models;

namespace blaga_anemona_Lab2ok.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext _context;

        public CreateModel(blaga_anemona_Lab2ok.Data.blaga_anemona_Lab2okContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID",
"PublisherName");
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
