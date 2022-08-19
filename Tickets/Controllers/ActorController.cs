using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;
        public ActorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Actors.ToListAsync();
            return View();
        }
    }
}
