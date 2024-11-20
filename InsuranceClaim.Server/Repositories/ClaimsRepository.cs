using InsuranceClaim.Server.Data;
using InsuranceClaim.Server.Model.Entities;
using InsuranceClaim.Server.Model.Enum;
using Microsoft.EntityFrameworkCore;

namespace InsuranceClaim.Server.Repositories
{
    public class ClaimsRepository
    {
        private readonly ClaimsDbContext _context;

        public ClaimsRepository(ClaimsDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Claim>> GetClaimsByStatusAsync(EnumStatus status)
        {
            return await _context.Claims.Where(c => c.ClaimStatus == status).ToListAsync();
        }

        public async Task<Claim> GetClaimByIdAsync(Guid id)
        {
            return await _context.Claims.FindAsync(id);
        }

        public async Task AddClaimAsync(Claim claim)
        {
            claim.Id = Guid.NewGuid();
            _context.Claims.Add(claim);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClaimAsync(Claim claim)
        {
            _context.Claims.Update(claim);
            await _context.SaveChangesAsync();
        }
    }
}
