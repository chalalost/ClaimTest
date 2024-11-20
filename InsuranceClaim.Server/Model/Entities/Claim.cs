using InsuranceClaim.Server.Model.Enum;

namespace InsuranceClaim.Server.Model.Entities
{
    public class Claim
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public double ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
        public DateTime ClaimDate { get; set; }
        public EnumStatus Status { get; set; } = EnumStatus.Pending;
    }
}
