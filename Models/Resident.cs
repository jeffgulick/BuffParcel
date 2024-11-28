using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Models;

public class Resident
{
    public int Id { get; set; } // PK
    
    [StringLength(30)]
    public string FullName { get; set; } = string.Empty;
    
    [EmailAddress]
    [StringLength(30)]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public int UnitNumber { get; set; }

    public List<Package> Packages { get; set; } = new List<Package>(); // Nav prop
}