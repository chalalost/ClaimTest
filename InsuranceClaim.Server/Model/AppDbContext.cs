using System.Collections.Generic;
using InsuranceClaim.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsuranceClaim.Server.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; }


    }
}
