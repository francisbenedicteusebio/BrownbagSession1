using BrownbagSession1.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1.Services
{
    [TestClass()]
    public class CandidateServiceTests
    {
        private readonly BrownbagSession1.Services.CandidateService _service;

        public CandidateServiceTests(CandidateService service)
        {
            _service = service;
        }

        [TestMethod()]
        public void GetCandidateAsyncTest()
        {
            var result = _service.GetCandidateAsync();
            Assert.IsNotNull(result);
        }
    }
}