namespace InsuranceClaim.ClientBlazor.Components.Layout.Shared
{
    public class ClaimSubmitDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
