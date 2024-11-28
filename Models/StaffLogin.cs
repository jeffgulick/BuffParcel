using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Models;

public class StaffLogin
{
    public int StaffLoginID { get; set; } // PK

    [StringLength(30)]
    public string StaffUsername { get; set; } = string.Empty;
    
    [StringLength(30)]
    public string StaffPassword { get; set; } = string.Empty;
}