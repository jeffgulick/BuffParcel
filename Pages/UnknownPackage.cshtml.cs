using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BuffParcel.Models;
using BuffParcel.Services;

namespace BuffParcel.Pages
{
    public class UnknownPackageModel : PageModel
    {
        private readonly PackageService _packageService;

        public UnknownPackageModel(PackageService packageService)
        {
            _packageService = packageService;
        }

        public List<UnknownPackage> UnknownPackages { get; set; } = new List<UnknownPackage>();

        public async Task OnGetAsync()
        {
            UnknownPackages = await _packageService.GetUnknownPackagesAsync();
        }
    }
}