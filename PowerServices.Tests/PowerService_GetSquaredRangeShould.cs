using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using PowerService.Services;

namespace PowerServices.Tests
{
    public class PowerService_GetSquaredRangeShould
    {
        [Fact]
        public void GetSquaredRange_InputIs02_CorrectLength()
        {
            var powerService = new PowerServiceWorker();
            int[] result = powerService.GetSquaredRange(0, 2);
            Assert.Equal(3, result.Length);
        }
    }
}