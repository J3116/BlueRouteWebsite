using BluelineWebsite.Data;
using BluelineWebsite.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BluelineWebsite.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Projects
        public async Task<IActionResult> Index()
        {
            var isArabic = IsCurrentCultureArabic();

            var projects = await _context.Projects
                .Include(p => p.Service)
                .AsNoTracking()
                .ToListAsync();

            ViewBag.IsArabic = isArabic;
            return View(projects);
        }

        private bool IsCurrentCultureArabic()
        {
            var requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var currentCulture = requestCulture?.RequestCulture.Culture.Name ?? "en-US";
            return currentCulture.StartsWith("ar", StringComparison.OrdinalIgnoreCase);
        }
    }
}