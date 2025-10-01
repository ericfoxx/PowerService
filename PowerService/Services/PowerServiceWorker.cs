using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PowerService.Services
{
    /// <summary>
    /// A service providing data structures and methods which allow the generation of powers (x^2,x^3,etc.)
    /// </summary>
    public class PowerServiceWorker : IPowerService
    {
        private int[][] Powers { get; set; }

        public PowerServiceWorker() => Powers = [];

        public void TestUsage()
        {
            Console.WriteLine("PowerService initiated");
        }

        public void Run(bool initSquares, bool initCubes, bool initFourths)
        {
            throw new NotImplementedException();
        }

        public int[] GetSquared()
        {
            throw new NotImplementedException();
        }

        public int[] GetSquaredRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public int GetSquare(int index)
        {
            throw new NotImplementedException();
        }

        public int[] GetCubed()
        {
            throw new NotImplementedException();
        }

        public int[] GetCubedRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public int GetCube(int index)
        {
            throw new NotImplementedException();
        }

        public int[] GetFourth()
        {
            throw new NotImplementedException();
        }

        public int[] GetFourthRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public int GetFourth(int index)
        {
            throw new NotImplementedException();
        }

        public int GetAllPowers(int index)
        {
            throw new NotImplementedException();
        }
    }
}