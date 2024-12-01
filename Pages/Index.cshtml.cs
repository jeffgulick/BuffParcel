using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuffParcel.Models;

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

    [BindProperty(SupportsGet = true)]
    public string SearchTerm { get; set; } = string.Empty;

    [BindProperty(SupportsGet = true)]
    public int PageIndex { get; set; } = 1;

    public int TotalPages { get; set; }

    public async Task<IActionResult> OnGetAsync()
    {
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }

        var query = _context.Packages!
            .Include(p => p.Resident)
            .OrderBy(p => p.IsPickedUp)
            .ThenBy(p => p.DeliveryDate)
            .AsQueryable();

        if (!string.IsNullOrEmpty(SearchTerm))
        {
            query = query.Where(p => p.Resident!.FullName.Contains(SearchTerm) || p.Resident.UnitNumber.ToString().Contains(SearchTerm));
        }

        int pageSize = 5;
        int totalRecords = await query.CountAsync();
        TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

        PendingDeliveries = await query
            .Skip((PageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return Page();
    }

    public async Task<IActionResult> OnPostPickupAsync(int packageId)
    {
        var package = await _context.Packages!.FindAsync(packageId);
        if (package == null)
        {
            return NotFound();
        }

        package.IsPickedUp = true;
        package.PickupDate = DateTime.Now;

        await _context.SaveChangesAsync();

        return RedirectToPage();
    }
}