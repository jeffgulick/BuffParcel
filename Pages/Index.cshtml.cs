using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffParcel.Models;
using BuffParcel.Services;

namespace BuffParcel.Pages;

public class IndexModel : PageModel
{
    private readonly PackageService _packageService;

    public IndexModel(PackageService packageService)
    {
        _packageService = packageService;
    }

    public int TotalPages { get; set; }
    public List<Package>? PendingDeliveries { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SearchTerm { get; set; }

    [BindProperty(SupportsGet = true)]
    public int PageIndex { get; set; } = 1;

    public async Task<IActionResult> OnGetAsync()
    {
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }

        int pageSize = 10;
        var result = await _packageService.GetPackagesAsync(SearchTerm!, PageIndex, pageSize);
        TotalPages = result.TotalPages;
        PendingDeliveries = result.PendingDeliveries;

        return Page();
    }

    public IActionResult OnPostLogout()
    {
        HttpContext.Session.Clear();
        return RedirectToPage("/Login");
    }

    public async Task<IActionResult> OnPostPickupAsync(int packageId)
    {
        bool success = await _packageService.PickupPackageAsync(packageId);
        if (!success)
        {
            return NotFound();
        }

        return RedirectToPage();
    }
}