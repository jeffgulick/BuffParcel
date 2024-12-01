using System.ComponentModel.DataAnnotations;

namespace BuffParcel.Models
{
    public class UnknownPackage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string OwnerName { get; set; } = string.Empty;

        [StringLength(50)]
        public string PostalService { get; set; } = string.Empty;

        [Required]
        public DateTime DeliveryDate { get; set; }

        public bool IsReturned { get; set; } = false;
    }
}