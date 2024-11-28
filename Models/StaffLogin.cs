using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Models;

public class StaffLogin
{
    [StringLength(30)]
    public string StaffUsername { get; set; } = string.Empty;
    
    [StringLength(30)]
    public string StaffPassword { get; set; } = string.Empty;
}