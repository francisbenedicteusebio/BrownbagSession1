using System.Linq;
using System.Runtime.InteropServices;
using BrownbagSession1.Data;
using BrownbagSession1.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrownbagSession1Tests.Services
{
    [TestClass()]
    public class CandidateServiceTests
    {
        private readonly BrownbagSessionDbContext _context;

        public CandidateServiceTests(BrownbagSessionDbContext context)
        {
            _context = context;
        }

        [TestMethod()]
        public void GetCandidateAsyncTest()
        {
            ICandidateService candidateService = new CandidateService(_context);
            var result = candidateService.GetCandidateAsync();
            Assert.IsNull(result);
            
        }
    }
}