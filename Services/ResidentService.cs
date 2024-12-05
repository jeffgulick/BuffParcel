using BuffParcel.Models;
using Microsoft.EntityFrameworkCore;

namespace BuffParcel.Services;

public class ResidentService
{
    private readonly PackageDbContext _context;

    public ResidentService(PackageDbContext context)
    {
        _context = context;
    }

    public async Task<Resident?> GetResidentWithPackagesAsync(string fullName, int unitNumber)
    {
        return await _context.Residents!
            .Include(r => r.Packages)
            .FirstOrDefaultAsync(r => r.FullName == fullName && r.UnitNumber == unitNumber);
    }

    public async Task<String?> GetResidentNameAsync(int residentId)
    {
        var resident = await _context.Residents!.FindAsync(residentId);
        return resident?.FullName;
    }

    public async Task<string?> GetResidentNameByPackageIdAsync(int packageId)
    {
        var package = await _context.Packages!
            .Include(p => p.Resident)
            .FirstOrDefaultAsync(p => p.Id == packageId);

        return package?.Resident?.FullName;
    }
}