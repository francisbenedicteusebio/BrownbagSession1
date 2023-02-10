using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BrownbagSession1.Models;
using BrownbagSession1.Services;

namespace BrownbagSession1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatesController : ControllerBase
    {
        private volatile ICandidateService _candidateService;

        public CandidatesController(ICandidateService candidateService)
        {
            _candidateService = candidateService ?? throw new ArgumentNullException(nameof(candidateService));
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidate()
        {
            var candidateList = await _candidateService.GetCandidateAsync();
            return candidateList;
        }
        
        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            await _candidateService.AddCandidateAsync(candidate);
            return CreatedAtAction("GetCandidate", new { id = candidate.Id }, candidate);
        }
    }
}
