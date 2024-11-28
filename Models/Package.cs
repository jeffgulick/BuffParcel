using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Models;

public class Package
{
    public int Id { get; set; }
    
    [Required]
    public int ResidentId { get; set; }
    
    public Resident? Resident { get; set; } // Nav prop
    
    [StringLength(50)]
    public string PostalService { get; set; } = string.Empty;
    
    [Required]
    public DateTime DeliveryDate { get; set; }
    
    public DateTime PickupDate { get; set; }
    
    public bool IsPickedUp { get; set; } = false;
    
    public bool IsUnknown { get; set; } = false;
}