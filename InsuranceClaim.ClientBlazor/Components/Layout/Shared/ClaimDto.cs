using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.ClientBlazor.Components.Layout.Shared
{
    public class ClaimDto
    {
        public Guid Id { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public DateTime ClaimDate { get; set; } = DateTime.UtcNow;
        public EnumStatus ClaimStatus { get; set; }
    }
}
