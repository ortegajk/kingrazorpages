#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kingrazorpages.Data;

namespace kingrazorpages.Pages.skills
{
    public class IndexModel : PageModel
    {
        private readonly kingrazorpages.Data.kingrazorpagesContext _context;

        public IndexModel(kingrazorpages.Data.kingrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
