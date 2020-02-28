using Application.Interfaces;
using Model.Day1;

namespace Application.Solvers
{
    public class Day1Solver : ISolver
    {
        public Solution GetSolution(IInput input)
        {
            Character iam = new Character();
            foreach (string command in input.GetCommaSeparatedValues())
            {
                Movement movement = CreateMovement(command);
                iam.MakeMove(movement);
            }
            return new Solution(iam.GetTaxicabDistance(), iam.DistanceFirstRevisitedPosition);
        }

        private Movement CreateMovement(string command)
        {
            Turn turn = command[0] == 'R' ? Turn.Right : Turn.Left;
            int steps = int.Parse(command[1..]);
            return new Movement(turn, steps);
        }
    }
}
