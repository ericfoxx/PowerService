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
        public List<uint> GetSquared();
        public List<uint> GetSquaredRange(int min, int max);
        public uint GetSquare(int index);
        public void SetSquaredTo(int max);
        public List<uint> GetCubed();
        public List<uint> GetCubedRange(int min, int max);
        public uint GetCube(int index);
        public void SetCubedTo(int max);
        public List<uint> GetFourth();
        public List<uint> GetFourthRange(int min, int max);
        public uint GetFourth(int index);
        public void SetFourthTo(int max);
        public List<List<uint>> GetAllPowers(int index);
    }
}