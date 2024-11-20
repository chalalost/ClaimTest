using FluentValidation;
using InsuranceClaim.Server.Model.DTOs;

namespace InsuranceClaim.Server.Validators
{
    public class ClaimSubmissionDtoValidator : AbstractValidator<ClaimSubmissionDto>
    {
        public ClaimSubmissionDtoValidator()
        {
            RuleFor(c => c.CustomerName)
                .NotEmpty().WithMessage("Customer name is required.")
                .MaximumLength(100).WithMessage("Customer name must not exceed 100 characters.");

            RuleFor(c => c.ClaimAmount)
                .GreaterThan(0).WithMessage("Claim amount must be greater than zero.");

            RuleFor(c => c.ClaimDescription)
                .NotEmpty().WithMessage("Claim description is required.")
                .MaximumLength(500).WithMessage("Claim description must not exceed 500 characters.");
        }
    }
}
