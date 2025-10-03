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
        private uint[][] Powers { get; set; }
        private const int MAX_SQUARE_INDEX = 65535;
        private const int MAX_CUBE_INDEX = 1625;
        private const int MAX_FOURTH_INDEX = 255;        

        public PowerServiceWorker() => Powers = [[0, 1], [0, 1], [0, 1]];

        public void TestUsage()
        {
            Console.WriteLine("PowerService initiated");
        }

        public void Run(bool initSquares, bool initCubes, bool initFourths)
        {
            //TODO: Handle serial/deserialization
            throw new NotImplementedException();
        }

        public uint[] GetSquared()
        {
            throw new NotImplementedException();
        }

        public uint[] GetSquaredRange(int min, int max)
        {
            //TODO: Implement bounds checking
            if (Powers[0].Length <= min)
            {
                throw new ArgumentException("TODO: implement catch-up logic");
            }
            for (int i = min; i < max; i++)
            {
                if (i < 2) continue;
                var h = Powers[0][i - 1]; //       * *
                Powers[0][i] = (uint)(h + h + i); // 2^2 = h *
            }
            var top = max + 1;

            return Powers[0][min..top];
        }

        public uint GetSquare(int index)
        {
            //Check against max & length
            throw new NotImplementedException();
            //return Powers[0][(int)index];
        }

        public uint[] GetCubed()
        {
            throw new NotImplementedException();
        }

        public uint[] GetCubedRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public uint GetCube(int index)
        {
            throw new NotImplementedException();
        }

        public uint[] GetFourth()
        {
            throw new NotImplementedException();
        }

        public uint[] GetFourthRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public uint GetFourth(int index)
        {
            throw new NotImplementedException();
        }

        public uint[] GetAllPowers(int index)
        {
            throw new NotImplementedException();
        }
    }
}