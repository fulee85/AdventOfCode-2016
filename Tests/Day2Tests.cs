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
            StringInput input = new StringInput("ULL", "RRDDD", "LURDL", "UUUUD");
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

        [Fact]
        public void TestPartOne3()
        {
            StringInput input = new StringInput(@"UU");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).FirstPart.Should().Be("2");
        }

        [Fact]
        public void TestPartOne4()
        {
            StringInput input = new StringInput(@"");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).FirstPart.Should().Be("5");
        }

        /// <summary>
        ///    1
        ///  2 3 4
        ///5 6 7 8 9
        ///  A B C
        ///    D
        /// </summary>
        [Fact]
        public void TestPartTwo1()
        {
            StringInput input = new StringInput("U");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).SecondPart.Should().Be("5");
        }

        [Fact]
        public void TestPartTwo2()
        {
            StringInput input = new StringInput("ULL", "RRDDD", "LURDL", "UUUUD");
            Day2Solver solution = new Day2Solver();
            solution.GetSolution(input).SecondPart.Should().Be("5DB3");
        }
    }
}
