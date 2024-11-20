using InsuranceClaim.Server.Entities;
using InsuranceClaim.Server.Model;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceClaim.Server.Controllers
{
    public class ClaimController : Controller
    {
        private readonly AppDbContext _context;
        private readonly Random _random = new();

        public ClaimController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Claim Submission API
        [HttpPost("submit")]
        public async Task<IActionResult> SubmitClaim([FromBody] Claim claim)
        {
            claim.Status = "Pending";
            claim.ClaimDate = DateTime.UtcNow;
            _context.Claims.Add(claim);
            await _context.SaveChangesAsync();
            return Ok(claim);
        }

        // 2. Claim Processing API
        [HttpPost("process/{id}")]
        public async Task<IActionResult> ProcessClaim(int id)
        {
            var claim = await _context.Claims.FindAsync(id);
            if (claim == null) return NotFound();

            claim.Status = _random.Next(0, 2) == 0 ? "Approved" : "Rejected";
            await _context.SaveChangesAsync();
            return Ok(claim);
        }

        // 3. Retrieve Claims API
        [HttpGet("status/{status}")]
        public IActionResult GetClaimsByStatus(string status)
        {
            var claims = _context.Claims.Where(c => c.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
            return Ok(claims);
        }
    }
}
