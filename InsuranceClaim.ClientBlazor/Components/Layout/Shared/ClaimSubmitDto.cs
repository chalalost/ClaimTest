using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.ClientBlazor.Components.Layout.Shared
{
    public class ClaimSubmitDto
    {
        [Required(ErrorMessage = "Customer name is required.")]
        public string CustomerName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Claim amount is required.")]
        [Range(1, double.MaxValue, ErrorMessage = "Claim amount must be greater than 0.")]
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
    }
}
