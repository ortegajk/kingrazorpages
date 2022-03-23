#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kingrazorpages.Pages.skills;

namespace kingrazorpages.Data
{
    public class kingrazorpagesContext : DbContext
    {
        public kingrazorpagesContext (DbContextOptions<kingrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<kingrazorpages.Pages.skills.Class> Class { get; set; }
    }
}
