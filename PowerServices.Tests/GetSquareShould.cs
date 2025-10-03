using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using PowerService.Services;

namespace PowerServices.Tests
{
    public class GetSquareShould
    {
        [Theory]
        [ClassData(typeof(GetSquareTestData))]
        public void Provide_CorrectValue(int value, uint expected)
        {
            var powerService = new PowerServiceWorker();
            var result = powerService.GetSquare(value);
            Assert.Equal(expected, result);
        }
    }

    public class GetSquareTestData : TheoryData<int, uint>
    {
        public GetSquareTestData()
        {
            Add(0, 0);
            Add(1, 1);
            Add(2, 4);
            Add(3, 9);
            Add(65535, 4294836225);
        }
    }

}