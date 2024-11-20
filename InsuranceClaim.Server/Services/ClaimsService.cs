﻿using InsuranceClaim.Server.Model.Entities;
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

        public async Task<IEnumerable<Claim>> GetClaimsByStatusAsync(EnumStatus status)
        {
            return await _repository.GetClaimsByStatusAsync(status);
        }

        public async Task<Claim> ProcessClaimAsync(int id)
        {
            var claim = await _repository.GetClaimByIdAsync(id);
            if (claim == null) return null;

            claim.Status = claim.GetRandomStatus();
            await _repository.UpdateClaimAsync(claim);

            return claim;
        }

        public async Task AddClaimAsync(Claim claim)
        {
            await _repository.AddClaimAsync(claim);
        }
    }

    public static class ClaimExtensions
    {
        private static readonly Random _random = new();

        public static EnumStatus GetRandomStatus(this Claim claim)
        {
            return _random.Next(2) == 0 ? EnumStatus.Approved : EnumStatus.Rejected;
        }
    }
}
