using BluelineWebsite.Data;
using BluelineWebsite.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BluelineWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var isArabic = IsCurrentCultureArabic();

            var viewModel = new HomeViewModel
            {
                FeaturedServices = await _context.Services
                    .Where(s => s.IsActive)
                    .Take(3)
                    .AsNoTracking()
                    .ToListAsync(),

                FeaturedProjects = await _context.Projects
                    .Include(p => p.Service)
                    .Take(3)
                    .AsNoTracking()
                    .ToListAsync(),

                IsArabic = isArabic
            };

            return View(viewModel);
        }
        public IActionResult About()
        {
            // Assuming you have the IsCurrentCultureArabic() helper method from earlier
            ViewBag.IsArabic = IsCurrentCultureArabic();
            return View();
        }
        private bool IsCurrentCultureArabic()
        {
            var requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var currentCulture = requestCulture?.RequestCulture.Culture.Name ?? "en-US";
            return currentCulture.StartsWith("ar", StringComparison.OrdinalIgnoreCase);
        }
    }
}