using AutoMapper;
using InsuranceClaim.Server.Data;
using InsuranceClaim.Server.Data.Entities;
using InsuranceClaim.Server.Model.DTOs;
using InsuranceClaim.Server.Model.Enum;
using InsuranceClaim.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceClaim.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        private readonly IClaimsService _service;

        public ClaimsController(IClaimsService service)
        {
            _service = service;
        }


        [HttpPost("submit-claim")]
        public async Task<IActionResult> SubmitClaim([FromBody] ClaimSubmissionDto claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var claimRequest = new Claim
            {
                CustomerName = claim.CustomerName,
                ClaimAmount = claim.ClaimAmount,
                ClaimDescription = claim.ClaimDescription,
                ClaimDate = DateTime.UtcNow,
                ClaimStatus = EnumStatus.Pending
            };

            await _service.AddClaimAsync(claimRequest);
            return Ok(claim);
        }

        [HttpPost("process-claim/{id}")]
        public async Task<IActionResult> ProcessClaim(Guid id)
        {
            var claim = await _service.ProcessClaimAsync(id);
            if (claim == null) return NotFound();

            return Ok(claim);
        }

        [HttpGet("get-all-claims")]
        public async Task<IActionResult> GetAllClaims()
        {
            var claims = await _service.GetAllAsync();
            return Ok(claims);
        }

        [HttpGet("retrieve-claims")]
        public async Task<IActionResult> RetrieveClaims([FromQuery] EnumStatus status)
        {
            var claims = await _service.GetClaimsByStatusAsync(status);
            return Ok(claims);
        }
    }
}
