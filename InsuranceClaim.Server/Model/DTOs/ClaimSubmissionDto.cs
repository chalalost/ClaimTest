using InsuranceClaim.Server.Model.Enum;
using System.ComponentModel.DataAnnotations;

namespace InsuranceClaim.Server.Model.DTOs
{
    public class ClaimSubmissionDto
    {
        public string CustomerName { get; set; } = string.Empty;
        public decimal ClaimAmount { get; set; }
        public string ClaimDescription { get; set; } = string.Empty;
    }
}
