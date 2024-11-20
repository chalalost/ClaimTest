using System.Collections.Generic;
using InsuranceClaim.Server.Model.Entities;
using InsuranceClaim.Server.Model.Enum;
using Microsoft.EntityFrameworkCore;

namespace InsuranceClaim.Server.Data
{
    public class ClaimsDbContext : DbContext
    {
        public ClaimsDbContext(DbContextOptions<ClaimsDbContext> options) : base(options) { }
        public DbSet<Claim> Claims { get; set; }
    }
}
