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

      public async Task<(int TotalPages, List<Package> PendingDeliveries)> GetPackagesAsync(string searchTerm, int pageIndex, int pageSize)
    {
        var query = _context.Packages!
            .Include(p => p.Resident)
            .OrderBy(p => p.IsPickedUp)
            .ThenBy(p => p.DeliveryDate)
            .AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(p => p.Resident!.FullName.Contains(searchTerm) || p.Resident.UnitNumber.ToString().Contains(searchTerm));
        }

        int totalRecords = await query.CountAsync();
        int totalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);

        var pendingDeliveries = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (totalPages, pendingDeliveries);
    }
    
    public async Task<List<UnknownPackage>> GetUnknownPackagesAsync()
    {
        return await _context.UnknownPackages!.ToListAsync();
    }

    public async Task<bool> PickupPackageAsync(int packageId)
    {
        var package = await _context.Packages!.FindAsync(packageId);
        if (package == null)
        {
            return false;
        }

        package.IsPickedUp = true;
        package.PickupDate = DateTime.Now;

        await _context.SaveChangesAsync();

        return true;
    }
}