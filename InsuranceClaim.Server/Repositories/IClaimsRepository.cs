using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.Enum;

namespace InsuranceClaim.Server.Repositories
{
    public interface IClaimsRepository
    {
        Task UpdateClaimAsync(Claim claim);
        Task AddClaimAsync(Claim claim);
        Task<Claim> GetClaimByIdAsync(Guid id);
        Task<IEnumerable<Claim>> GetClaimsByStatusAsync(EnumStatus status);
        Task<List<Claim>> GetAllAsync();

    }
}
