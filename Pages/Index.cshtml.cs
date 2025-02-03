using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffParcel.Models;
using BuffParcel.Services;

namespace BuffParcel.Pages;

public class IndexModel : PageModel
{
    private readonly PackageService _packageService;
    private readonly ResidentService _residentService;

    public IndexModel(PackageService packageService, ResidentService residentService)
    {
        _packageService = packageService;
        _residentService = residentService;
    }

    public int TotalPages { get; set; }
    public List<Package>? PendingDeliveries { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    [BindProperty(SupportsGet = true)]
    public int PageIndex { get; set; } = 1;

    // On page load
    public async Task<IActionResult> OnGetAsync()
    {
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }

        int pageSize = 3;
        var result = await _packageService.GetPackagesAsync(SearchTerm!, PageIndex, pageSize);
        TotalPages = result.TotalPages;
        PendingDeliveries = result.PendingDeliveries;

        return Page();
    }

    // Log out
    public IActionResult OnPostLogout()
    {
        HttpContext.Session.Clear();
        return RedirectToPage("/Login");
    }

    // Pick up a package
    public async Task<IActionResult> OnPostPickupAsync(int packageId)
    {
        bool success = await _packageService.PickupPackageAsync(packageId);
        if (!success)
        {
            return NotFound();
        }

        var residentName = await _residentService.GetResidentNameByPackageIdAsync(packageId);
        TempData["PickupConfirmation"] = $"Package {packageId} for resident {residentName} was processed as picked up on {DateTime.Now:yyyy-MM-dd}.";

        return RedirectToPage();
    }
}