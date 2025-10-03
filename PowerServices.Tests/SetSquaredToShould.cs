using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using PowerService.Services;

namespace PowerServices.Tests
{
    public class SetSquaredToShould
    {
        [Fact]
        public void IfInputIs_4_ThenIs_4_DoesNotError()
        {
            var powerService = new PowerServiceWorker();
            powerService.SetSquaredTo(4);
            var exception = Record.Exception(() => powerService.SetSquaredTo(4));
            Assert.Null(exception);
        }

        [Fact]
        public void IfInputIs_GreaterThanMax_Errors()
        {
            var powerService = new PowerServiceWorker();
            
            Assert.Throws<ArgumentException>(() => powerService.SetSquaredTo(1000000));
        }
    }
}