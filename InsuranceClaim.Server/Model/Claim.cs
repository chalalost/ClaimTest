namespace InsuranceClaim.Server.Entities
{
    public class Claim
    {
        public Guid Id { get; set; } // Auto-generated
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime ClaimDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending"; // Default status
    }
}
