using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.Enum;

namespace InsuranceClaim.Server.Extensions
{
    public static class ClaimExtensions
    {
        private static readonly Random _random = new();

        public static EnumStatus GetRandomStatus(this Claim claim)
        {
            return _random.Next(2) == 0 ? EnumStatus.Approved : EnumStatus.Rejected;
        }
    }
}
