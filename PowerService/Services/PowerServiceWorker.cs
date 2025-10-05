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
        private List<List<uint>> Powers { get; set; }
        public const int MAX_SQUARE_INDEX = 65535;
        public const int MAX_CUBE_INDEX = 1625;
        public const int MAX_FOURTH_INDEX = 255;        

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

        public List<uint> GetSquared()
        {
            SetSquaredTo(MAX_SQUARE_INDEX);

            return Powers[0];
        }

        public List<uint> GetSquaredRange(int min, int max)
        {
            SetSquaredTo(max);

            var top = max + 1;

            return Powers[0][min..top];
        }

        public uint GetSquare(int index)
        {
            SetSquaredTo(index);

            return Powers[0][index];
        }

        public void SetSquaredTo(int max)
        {
            var squares = Powers[0];

            if (max < 0) throw new ArgumentException($"Provided index is negative. Provide a positive index.");
            if (max < 2) return;
            if (max > MAX_SQUARE_INDEX) throw new ArgumentException($"Provided index {max} is greater than max square index {MAX_SQUARE_INDEX}.");

            if (squares.Count - 1 >= max) return;
            for (int i = squares.Count; i <= max; i++)
            {
                if (i < 2) continue;
                var h = squares[i - 1]; //                    i  i
                squares.Add((uint)(h + (i - 1) + i)); // 2^2 = [h] h
            }
            Powers[0] = squares;
            return;
        }

        public List<uint> GetCubed()
        {
            throw new NotImplementedException();
        }

        public List<uint> GetCubedRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public uint GetCube(int index)
        {
            throw new NotImplementedException();
        }

        public void SetCubedTo(int max)
        {
            var cubes = Powers[1];

            if (max < 0) throw new ArgumentException($"Provided index is negative. Provide a positive index.");
            if (max < 2) return;
            if (max > MAX_CUBE_INDEX) throw new ArgumentException($"Provided index {max} is greater than max cube index {MAX_CUBE_INDEX}.");

            SetSquaredTo(max);

            if (cubes.Count - 1 >= max) return;
            for (int i = cubes.Count; i <= max; i++)
            {
                if (i < 2) continue;
                var h = cubes[i - 1];
                var h2 = Powers[0][i - 1];
                var i2 = cubes[i];
                cubes.Add((uint)(h + (i - 1) + i));
            }
            Powers[1] = cubes;
            return;
        }

        public List<uint> GetFourth()
        {
            throw new NotImplementedException();
        }

        public List<uint> GetFourthRange(int min, int max)
        {
            throw new NotImplementedException();
        }

        public uint GetFourth(int index)
        {
            throw new NotImplementedException();
        }

        public void SetFourthTo(int max)
        {
            throw new NotImplementedException();
        }

        public List<List<uint>> GetAllPowers(int index)
        {
            throw new NotImplementedException();
        }
    }
}