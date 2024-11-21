using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.Enum;

namespace InsuranceClaim.Server.Services
{
    public interface IClaimsService
    {
        Task<List<Claim>> GetAllAsync();
        Task<IEnumerable<Claim>> GetClaimsByStatusAsync(EnumStatus status);
        Task<Claim> ProcessClaimAsync(Guid id);
        Task AddClaimAsync(Claim claim);
    }
}
