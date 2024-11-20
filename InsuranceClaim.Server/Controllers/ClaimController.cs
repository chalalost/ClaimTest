using InsuranceClaim.Server.Data;
using InsuranceClaim.Server.Model.Entities;
using InsuranceClaim.Server.Model.Enum;
using InsuranceClaim.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceClaim.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        private readonly ClaimsService _service;

        public ClaimsController(ClaimsService service)
        {
            _service = service;
        }

        [HttpPost("submit-claim")]
        public async Task<IActionResult> SubmitClaim([FromBody] Claim claim)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _service.AddClaimAsync(claim);
            return Ok(claim);
        }

        [HttpPost("process-claim/{id}")]
        public async Task<IActionResult> ProcessClaim(Guid id)
        {
            var claim = await _service.ProcessClaimAsync(id);
            if (claim == null) return NotFound();

            return Ok(claim);
        }

        [HttpGet("retrieve-claims")]
        public async Task<IActionResult> RetrieveClaims([FromQuery] EnumStatus status)
        {
            var claims = await _service.GetClaimsByStatusAsync(status);
            return Ok(claims);
        }
    }
}
