using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuffParcel.Models;

namespace BuffParcel.Pages;

public class LoginModel : PageModel
{
    private readonly PackageDbContext _context;

    [BindProperty]
    public string Username { get; set; } = default!;

    [BindProperty]
    public string Password { get; set; } = default!;

    public string ErrorMessage { get; set; } = string.Empty;

    public LoginModel(PackageDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        // Clear any existing session
        HttpContext.Session.Clear();
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
        {
            ErrorMessage = "Username and password are required.";
            return Page();
        }

        var staffLogin = await _context.StaffLogins!
            .FirstOrDefaultAsync(u => u.StaffUsername == Username && u.StaffPassword == Password);

        if (staffLogin != null)
        {
            // Set session to indicate logged in
            HttpContext.Session.SetString("IsLoggedIn", "true");
            return RedirectToPage("/Index");
        }

        ErrorMessage = "Invalid username or password.";
        return Page();
    }
}