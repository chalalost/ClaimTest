using InsuranceClaim.Server.Model.Entities;
using InsuranceClaim.Server.Model.Enum;

namespace InsuranceClaim.Server.Data
{
    public class DataSeeder
    {
        public static void Seed(ClaimsDbContext context)
        {
            if (!context.Claims.Any())
            {
                context.Claims.AddRange(
                    new Claim
                    {
                        CustomerName = "John Doe",
                        ClaimAmount = 1200.50m,
                        ClaimDescription = "Car accident in downtown",
                        Status = EnumStatus.Pending
                    },
                    new Claim
                    {
                        CustomerName = "Jane Smith",
                        ClaimAmount = 1500.00m,
                        ClaimDescription = "Water damage in home",
                        Status = EnumStatus.Pending
                    },
                    new Claim
                    {
                        CustomerName = "Tom Brown",
                        ClaimAmount = 800.00m,
                        ClaimDescription = "Stolen wallet",
                        Status = EnumStatus.Pending
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
