using Application.Interfaces;
using Application.Solvers;
using Infrastructure;
using System;

namespace AdventOfCode_2016
{
    /// <summary>
    /// https://adventofcode.com/2016
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            //RunSolver(new Day1Solver(), new FileInput("Inputs/input1.txt"));
            RunSolver(new Day2Solver(), new FileInput("Inputs/input2.txt"));
        }

        private static void RunSolver(ISolver solver, IInput input)
        {
            var solution = solver.GetSolution(input);
            Console.WriteLine("Part one solution: " + solution.FirstPart);
            Console.WriteLine("Part two solution: " + solution.SecondPart);
        }
    }
}
