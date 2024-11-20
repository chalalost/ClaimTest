using InsuranceClaim.Server.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Server.Model.Entities
{
    public class Claim
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }
        [Required]
        [Range(1, 1000000, ErrorMessage = "Claim amount must be between 1 and 1,000,000.")]
        public decimal ClaimAmount { get; set; }
        [Required]
        [StringLength(500)]
        public string ClaimDescription { get; set; }
        public DateTime ClaimDate { get; set; } = DateTime.UtcNow;
        public EnumStatus Status { get; set; } = EnumStatus.Pending;
    }
}
