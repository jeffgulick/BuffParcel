using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuffParcel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuffParcel.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly PackageDbContext _context;

    public IndexModel(ILogger<IndexModel> logger, PackageDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public List<Package> PendingDeliveries { get; set; } = new List<Package>();

    public async Task<IActionResult> OnGetAsync()
{
    if (HttpContext.Session.GetString("IsLoggedIn") != "true")
    {
        return RedirectToPage("/Login");
    }

    // Pulling all packages and resident info
    PendingDeliveries = await _context.Packages!
        .Include(p => p.Resident)
        .OrderBy(p => p.IsPickedUp)
        .ThenBy(p => p.DeliveryDate)
        .ToListAsync();

    return Page();
}

    public async Task<IActionResult> OnGetPickupAsync(int id)
    {
        var package = await _context.Packages!.FindAsync(id);
        if (package == null)
        {
            return NotFound();
        }

        package.IsPickedUp = true;
        package.PickupDate = DateTime.Now;

        await _context.SaveChangesAsync();

        return new JsonResult(new { success = true });
    }
}