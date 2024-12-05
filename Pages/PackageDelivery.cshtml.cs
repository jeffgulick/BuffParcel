using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuffParcel.Models;
using BuffParcel.Services;

namespace BuffParcel.Pages;

public class PackageDeliveryModel : PageModel
{
    private readonly PackageDbContext _context;
    private readonly PackageService _packageService;
    private readonly ResidentService _residentService;

    public PackageDeliveryModel(PackageDbContext context, PackageService packageService, ResidentService residentService)
    {
        _context = context;
        _packageService = packageService;
        _residentService = residentService;
    }

    public List<Resident>? Residents { get; set; }

    [BindProperty]
    public int SelectedResidentId { get; set; }

    [BindProperty]
    public string? PostalService { get; set; }

    [BindProperty]
    public bool IsUnknown { get; set; }

    [BindProperty]
    public string OwnerName { get; set; } = string.Empty;

    public async Task<IActionResult> OnGetAsync()
    {
        // Check if user is logged in
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }

        // Load residents for dropdown
        Residents = await _context.Residents!.OrderBy(r => r.FullName).ToListAsync();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (IsUnknown)
        {
            if (string.IsNullOrEmpty(OwnerName) || string.IsNullOrEmpty(PostalService))
            {
                ModelState.AddModelError("", "Please provide the owner's name and postal service for unknown packages.");
                Residents = await _context.Residents!.ToListAsync();
                return Page();
            }

            // Adding unknown package to database
            await _packageService.AddUnknownPackageAsync(OwnerName, PostalService);
            TempData["PackageConfirmation"] = $"Unknown package for {OwnerName} was received and its status is 'Unknown Package'.";
        }
        else
        {
            if (SelectedResidentId == 0 || string.IsNullOrEmpty(PostalService))
            {
                ModelState.AddModelError("", "Please select a resident and postal service.");
                Residents = await _context.Residents!.ToListAsync();
                return Page();
            }

            // fetches the name of the resident based on Id
            var residentName = await _residentService.GetResidentNameAsync(SelectedResidentId);

            // Adding package to database
            await _packageService.AddPackageAsync(SelectedResidentId, PostalService);
            TempData["PackageConfirmation"] = $"Package for resident {residentName} was received and its status is 'Pending'.";
        }

        return RedirectToPage();
    }
}