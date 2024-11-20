namespace InsuranceClaim.ClientBlazor.Components.Layout.Shared
{
    public class ClaimDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; }
        public string Status { get; set; }
        public DateTime ClaimDate { get; set; }
    }
}
