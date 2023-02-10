using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using BrownbagSession1.Data;
using BrownbagSession1.Helpers;
using BrownbagSession1.Models;
using Microsoft.EntityFrameworkCore;

namespace BrownbagSession1.Services
{
    public interface ICandidateService
    {
        Task<List<Candidate>> GetCandidateAsync();
        Task<int> AddCandidateAsync(Candidate candidate);
    }
    public class CandidateService : ICandidateService
    {
        private readonly BrownbagSessionDbContext _context;

        public CandidateService(BrownbagSessionDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<Candidate>> GetCandidateAsync()
        {
            var result = await _context.Candidate.ToListAsync();

            //further 'behind the scenes'
            if (result.Any())
            {
                foreach (var d in result)
                {
                    d.Age = DateHelper.ComputeAge(d.DateOfBirth);
                }
            }
            
            return result;
        }

        public async Task<int> AddCandidateAsync(Candidate candidate)
        {
            _context.Candidate.Add(candidate);
            await _context.SaveChangesAsync();

            return candidate.Id;
        }
    }
}
