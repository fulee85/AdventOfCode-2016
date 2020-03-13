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
            int possibleVerticalTriangleCount = 0;
            int lineCount = 0;
            int[][] verticalTriangleSides = new int[][] {
                new int[3],
                new int[3],
                new int[3],
            };

            foreach (var line in input.GetLines())
            {
                //Part one
                var sides = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
                if (Triangle.IsValid(sides))
                {
                    possibleTriangleCount++;
                }

                //Part two
                verticalTriangleSides[0][lineCount] = sides[0];
                verticalTriangleSides[1][lineCount] = sides[1];
                verticalTriangleSides[2][lineCount] = sides[2];
                if (lineCount == 2)
                {
                    possibleVerticalTriangleCount += verticalTriangleSides.Count(sides => Triangle.IsValid(sides));
                    lineCount = 0;
                }
                else
                {
                    lineCount++;
                }
            }

            return new Solution(possibleTriangleCount, possibleVerticalTriangleCount);
        }
    }
}
