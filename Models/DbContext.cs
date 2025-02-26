using Microsoft.EntityFrameworkCore;


namespace BuffParcel.Models;


public class PackageDbContext : DbContext
{
    public PackageDbContext(DbContextOptions<PackageDbContext> options) 
        : base(options) {}
    
    public DbSet<Resident>? Residents { get; set; }
    public DbSet<Package>? Packages { get; set; }
    public DbSet<StaffLogin>? StaffLogins { get; set; }
    public DbSet<UnknownPackage>? UnknownPackages { get; set; }

}