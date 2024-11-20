using InsuranceClaim.Server.Enum;

namespace InsuranceClaim.Server.Entities
{
    public class Claim
    {
        public Guid Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public double Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime ClaimDate { get; set; }
        public EnumStatus Status { get; set; }
    }
}
