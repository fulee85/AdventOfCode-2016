using Application.Interfaces;
using Model.Day3;
using System.Linq;

namespace Application.Solvers
{
    public class Day3Solver : ISolver
    {
        public Solution GetSolution(IInput input)
        {
            int possibleTriangleCount = 0;
            foreach (var line in input.GetLines())
            {
                var sides = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
                if (Triangle.IsValid(sides[0], sides[1], sides[2]))
                {
                    possibleTriangleCount++;
                }
            }
            return new Solution(possibleTriangleCount);
        }
    }
}
