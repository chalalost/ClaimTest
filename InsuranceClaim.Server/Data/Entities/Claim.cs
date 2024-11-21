using InsuranceClaim.Server.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Server.Data.Entities
{
    public partial class Claim
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
        public DateTime? ClaimDate { get; set; } = DateTime.UtcNow;
        public EnumStatus ClaimStatus { get; set; } = EnumStatus.Pending;
    }
}
