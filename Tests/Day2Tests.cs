using Application.Solvers;
using FluentAssertions;
using Tests.Utilities;
using Xunit;

namespace Tests
{
    public class Day2Tests
    {
        [Fact]
        public void TestPartOne1()
        {
            StringInput input = new StringInput(@"ULL
RRDDD
LURDL
UUUUD");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).FirstPart.Should().Be("1985");
        }

        [Fact]
        public void TestPartOne2()
        {
            StringInput input = new StringInput(@"U");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).FirstPart.Should().Be("2");
        }
    }
}
