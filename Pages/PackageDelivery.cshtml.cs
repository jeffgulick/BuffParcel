using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuffParcel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuffParcel.Pages;

public class PackageDeliveryModel : PageModel
{
    private readonly PackageDbContext _context;

    public List<Resident>? Residents { get; set; }

    [BindProperty]
    public int SelectedResidentId { get; set; }

    [BindProperty]
    public string? PostalService { get; set; }

    [BindProperty]
    public bool IsUnknown { get; set; }

    [BindProperty]
    public string OwnerName { get; set; } = string.Empty;

    public PackageDeliveryModel(PackageDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        // Check if user is logged in
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }

        // Load residents for dropdown
        Residents = await _context.Residents!.ToListAsync();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        // Validate input
        if (IsUnknown)
        {
            if (string.IsNullOrEmpty(OwnerName) || string.IsNullOrEmpty(PostalService))
            {
                ModelState.AddModelError("", "Please provide the owner's name and postal service for unknown packages.");
                Residents = await _context.Residents!.ToListAsync();
                return Page();
            }

            // Create new unknown package record
            var unknownPackage = new UnknownPackage
            {
                OwnerName = OwnerName,
                PostalService = PostalService,
                DeliveryDate = DateTime.Now,
                IsReturned = false
            };

            // Save unknown package to database
            _context.UnknownPackages!.Add(unknownPackage);
        }
        else
        {
            if (SelectedResidentId == 0 || string.IsNullOrEmpty(PostalService))
            {
                ModelState.AddModelError("", "Please select a resident and postal service.");
                Residents = await _context.Residents!.ToListAsync();
                return Page();
            }

            // Create new package record
            var package = new Package
            {
                PostalService = PostalService,
                DeliveryDate = DateTime.Now,
                IsPickedUp = false,
                ResidentId = SelectedResidentId
            };

            // Save package to database
            _context.Packages!.Add(package);
        }

        await _context.SaveChangesAsync();

        return RedirectToPage("/Index");
    }
}