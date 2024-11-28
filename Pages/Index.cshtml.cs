using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuffParcel.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IActionResult  OnGet()
    {
        if (HttpContext.Session.GetString("IsLoggedIn") != "true")
        {
            return RedirectToPage("/Login");
        }
        return Page();
    }
}
