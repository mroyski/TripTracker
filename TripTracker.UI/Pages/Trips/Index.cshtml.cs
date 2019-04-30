using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TripTracker.BackService.Models;
using TripTracker.UI.Data;

namespace TripTracker.UI.Pages.Trips
{
    public class IndexModel : PageModel
    {
        private readonly TripTracker.UI.Data.ApplicationDbContext _context;

        public IndexModel(TripTracker.UI.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Trip> Trip { get;set; }

        public async Task OnGetAsync()
        {
            Trip = await _context.Trip.ToListAsync();
        }
    }
}
