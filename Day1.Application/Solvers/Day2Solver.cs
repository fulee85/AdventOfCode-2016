using Application.Interfaces;
using Model.Day2;
using System;
using System.Text;

namespace Application.Solvers
{
    public class Day2Solver : ISolver
    {
        public Solution GetSolution(IInput input)
        {
            var keypad = new Keypad();
            var result = new StringBuilder();
            foreach (var line in input.GetLines())
            {
                foreach (var character in line)
                {
                    keypad.Move(character);
                }
                result.Append(keypad.GetNumber());
            }

            return new Solution(firstPart: result.ToString());
        }
    }
}
