using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using PowerService.Services;
using Xunit.Abstractions;

namespace PowerServices.Tests
{
    public class GetSquaredRangeShould(ITestOutputHelper output)
    {
        private readonly ITestOutputHelper output = output;

        [Fact]
        public void InputIs_0To1_CorrectList()
        {
            var powerService = new PowerServiceWorker();
            List<uint> result = powerService.GetSquaredRange(0, 1);
            //output.WriteLine("[" + string.Join(',', result) + "]");
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void InputIs_0To2_CorrectList()
        {
            var powerService = new PowerServiceWorker();
            List<uint> result = powerService.GetSquaredRange(0, 2);
            List<uint> expected = [0, 1, 4];
            //output.WriteLine("[" + string.Join(',',result) + "]");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void InputIs_4To7_ExpandsList()
        {
            var powerService = new PowerServiceWorker();
            List<uint> result = powerService.GetSquaredRange(4, 7);
            List<uint> expected = [16, 25, 36, 49];
            //output.WriteLine("[" + string.Join(',',result) + "]");
            Assert.Equal(expected, result);
        }
    }
}