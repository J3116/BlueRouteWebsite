using BluelineWebsite.Data;
using BluelineWebsite.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BluelineWebsite.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Contact
        public async Task<IActionResult> Index()
        {
            var isArabic = IsCurrentCultureArabic();
            await PopulateServicesDropDownListAsync(isArabic);

            ViewBag.IsArabic = isArabic;
            return View(new ContactInquiry());
        }

        // POST: /Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> Index([Bind("Id,FullName,Email,Phone,Subject,Message")] ContactInquiry contactInquiry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactInquiry);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = IsCurrentCultureArabic()
                    ? "تم إرسال رسالتك بنجاح. سنتواصل معك قريباً."
                    : "Your inquiry has been submitted successfully. We will contact you soon.";

                return RedirectToAction(nameof(Index));
            }

            // If validation fails, return the view with the current data
            ViewBag.IsArabic = IsCurrentCultureArabic();
            return View(contactInquiry);
        }

        private async Task PopulateServicesDropDownListAsync(bool isArabic)
        {
            var services = await _context.Services
                .Where(s => s.IsActive)
                .AsNoTracking()
                .ToListAsync();

            ViewBag.ServiceList = new SelectList(
                services,
                "Id",
                isArabic ? "TitleAr" : "TitleEn"
            );
        }

        private bool IsCurrentCultureArabic()
        {
            var requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var currentCulture = requestCulture?.RequestCulture.Culture.Name ?? "en-US";
            return currentCulture.StartsWith("ar", StringComparison.OrdinalIgnoreCase);
        }
    }
}