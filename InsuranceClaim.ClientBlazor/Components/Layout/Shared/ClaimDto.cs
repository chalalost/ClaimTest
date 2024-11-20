namespace InsuranceClaim.ClientBlazor.Components.Layout.Shared
{
    public class ClaimDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime ClaimDate { get; set; }
    }
}
