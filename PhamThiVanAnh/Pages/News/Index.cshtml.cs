#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamThiVanAnh.Models;

namespace PhamThiVanAnh.Pages_News
{
    #pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly CategoryContext _context;

        public IndexModel(CategoryContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            News = await _context.News.ToListAsync();
        }
    }
    #pragma warning restore CS8618
#pragma warning restore CS8604
}
