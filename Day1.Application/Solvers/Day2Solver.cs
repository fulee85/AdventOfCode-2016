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
            var specialKeypad = new SpecialKeypad();
            var result1 = new StringBuilder();
            var result2 = new StringBuilder();
            foreach (var line in input.GetLines())
            {
                foreach (var character in line)
                {
                    keypad.Move(character);
                    specialKeypad.Move(character);
                }
                result1.Append(keypad.GetCode());
                result2.Append(specialKeypad.GetCode());
            }

            return new Solution(firstPart: result1, secondPart: result2);
        }
    }
}
