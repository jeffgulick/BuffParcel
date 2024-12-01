using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffParcel.Models;
using BuffParcel.Services;
using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Pages;

public class PackageHistoryModel : PageModel
{
    private readonly ResidentService _residentService;

    public PackageHistoryModel(ResidentService residentService)
    {
        _residentService = residentService;
    }

    [BindProperty]
    [Required(ErrorMessage = "Unit number is required.")]
    public int UnitNumber { get; set; }

    [BindProperty]
    [Required(ErrorMessage = "Full name is required.")]
    public string FullName { get; set; } = string.Empty;

    public List<Package> Packages { get; set; } = new List<Package>();

    public void OnGet()
    {
        // Initial page load
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Use ResidentService to get the resident and package history
        var resident = await _residentService.GetResidentWithPackagesAsync(FullName, UnitNumber);

        if (resident != null)
        {
            // Load package history
            Packages = resident.Packages!
                .OrderByDescending(p => p.DeliveryDate)
                .ToList();
        }
        else
        {
            ModelState.AddModelError("", "Resident not found.");
        }

        return Page();
    }
}