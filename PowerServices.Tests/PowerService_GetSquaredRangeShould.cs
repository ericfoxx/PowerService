using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using PowerService.Services;
using Xunit.Abstractions;

namespace PowerServices.Tests
{
    public class PowerService_GetSquaredRangeShould(ITestOutputHelper output)
    {
        private readonly ITestOutputHelper output = output;

        [Fact]
        public void GetSquaredRange_InputIs01_CorrectLength()
        {
            var powerService = new PowerServiceWorker();
            uint[] result = powerService.GetSquaredRange(0, 1);
            output.WriteLine("[" + string.Join(',',result) + "]");
            Assert.Equal(2, result.Length);
        }
    }
}