using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.Extensions.DependencyInjection;

namespace PowerService.Services
{
    public interface IPowerService
    {
        //ServiceLifetime ILocalServiceLifetime.Lifetime => ServiceLifetime.Singleton;
        public void TestUsage();
        public void Run(bool initSquares, bool initCubes, bool initFourths);
        public int[] GetSquared();
        public int[] GetSquaredRange(int min, int max);
        public int GetSquare(int index);
        public int[] GetCubed();
        public int[] GetCubedRange(int min, int max);
        public int GetCube(int index);
        public int[] GetFourth();
        public int[] GetFourthRange(int min, int max);
        public int GetFourth(int index);
        public int GetAllPowers(int index);
    }
}