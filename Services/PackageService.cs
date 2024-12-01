using BuffParcel.Models;
using Microsoft.EntityFrameworkCore;

namespace BuffParcel.Services;

public class PackageService
{
    private readonly PackageDbContext _context;
    private readonly EmailService _emailService;

    public PackageService(PackageDbContext context, EmailService emailService)
    {
        _context = context;
        _emailService = emailService;
    }

    public async Task AddUnknownPackageAsync(string ownerName, string postalService)
    {
        var unknownPackage = new UnknownPackage
        {
            OwnerName = ownerName,
            PostalService = postalService,
            DeliveryDate = DateTime.Now,
            IsReturned = false
        };

        _context.UnknownPackages!.Add(unknownPackage);
        await _context.SaveChangesAsync();
    }

    public async Task AddPackageAsync(int residentId, string postalService)
    {
        var package = new Package
        {
            ResidentId = residentId,
            PostalService = postalService,
            DeliveryDate = DateTime.Now,
            IsPickedUp = false
        };

        _context.Packages!.Add(package);

        // Send email notification to the resident
        var resident = await _context.Residents!.FindAsync(residentId);
        if (resident != null)
        {
            _emailService.SendPackageNotification(resident.Email);
        }

        await _context.SaveChangesAsync();
    }
}