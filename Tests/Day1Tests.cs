using Application.Solvers;
using FluentAssertions;
using Tests.Utilities;
using Xunit;

namespace Tests
{
    public class Day1Tests
    {
        [Fact]
        public void TestPartOne1()
        {
            StringInput input = new StringInput("R2", "L3");
            Day1Solver solution = new Day1Solver();
            solution.GetSolution(input).FirstPart.Should().Be("5");
        }

        [Fact]
        public void TestPartOne2()
        {
            StringInput input = new StringInput("R2", "R2", "R2");
            Day1Solver solution = new Day1Solver();
            solution.GetSolution(input).FirstPart.Should().Be("2");
        }

        [Fact]
        public void TestPartOne3()
        {
            StringInput input = new StringInput("R5", "L5", "R5", "R3");
            Day1Solver solution = new Day1Solver();
            solution.GetSolution(input).FirstPart.Should().Be("12");
        }

        [Fact]
        public void TestPartTwo1()
        {
            StringInput input = new StringInput("R8", "R4", "R4", "R8");
            Day1Solver solution = new Day1Solver();
            solution.GetSolution(input).SecondPart.Should().Be("4");
        }
    }
}
