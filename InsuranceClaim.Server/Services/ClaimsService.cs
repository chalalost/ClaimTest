using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Extensions;
using InsuranceClaim.Server.Model.Enum;
using InsuranceClaim.Server.Repositories;

namespace InsuranceClaim.Server.Services
{
    public class ClaimsService
    {
        private readonly ClaimsRepository _repository;

        public ClaimsService(ClaimsRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Claim>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Claim>> GetClaimsByStatusAsync(EnumStatus status)
        {
            return await _repository.GetClaimsByStatusAsync(status);
        }

        public async Task<Claim> ProcessClaimAsync(Guid id)
        {
            var claim = await _repository.GetClaimByIdAsync(id);
            if(claim is not null)
            {
            claim.ClaimStatus = claim.GetRandomStatus();
            await _repository.UpdateClaimAsync(claim);
            }

            return claim;
        }

        public async Task AddClaimAsync(Claim claim)
        {
            await _repository.AddClaimAsync(claim);
        }
    }
}
