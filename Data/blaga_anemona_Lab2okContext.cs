using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blaga_anemona_Lab2ok.Models;

namespace blaga_anemona_Lab2ok.Data
{
    public class blaga_anemona_Lab2okContext : DbContext
    {
        public blaga_anemona_Lab2okContext (DbContextOptions<blaga_anemona_Lab2okContext> options)
            : base(options)
        {
        }

        public DbSet<blaga_anemona_Lab2ok.Models.Book> Book { get; set; } = default!;

        public DbSet<blaga_anemona_Lab2ok.Models.Publisher> Publisher { get; set; }
    }
}
