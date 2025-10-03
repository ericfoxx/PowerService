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
        public uint[] GetSquared();
        public uint[] GetSquaredRange(int min, int max);
        public uint GetSquare(int index);
        public uint[] GetCubed();
        public uint[] GetCubedRange(int min, int max);
        public uint GetCube(int index);
        public uint[] GetFourth();
        public uint[] GetFourthRange(int min, int max);
        public uint GetFourth(int index);
        public uint[] GetAllPowers(int index);
    }
}