using Application.Solvers;
using FluentAssertions;
using Model.Day3;
using Tests.Utilities;
using Xunit;

namespace Tests
{
    public class Day3Tests
    {
        [Fact]
        public void Triangle1Test()
        {
            Triangle.IsValid(5, 10, 25).Should().BeFalse();
            Triangle.IsValid(25, 10, 5).Should().BeFalse();
            Triangle.IsValid(5, 10, 10).Should().BeTrue();
            Triangle.IsValid(5, 10, 5).Should().BeFalse();
            Triangle.IsValid(5, 10, 6).Should().BeTrue();
        }

        [Fact]
        public void SolverTest1()
        {
            StringInput input = new StringInput("5 10 25", "25 10 5", "5 10 10", "5 10 5", "5 10 6");
            Day3Solver solution = new Day3Solver();
            solution.GetSolution(input).FirstPart.Should().Be("2");
        }
    }
}
