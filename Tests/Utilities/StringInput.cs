using Application.Interfaces;
using System.Collections.Generic;

namespace Tests.Utilities
{
    public class StringInput : IInput
    {
        private readonly string[] input;

        public StringInput(params string[] input)
        {
            this.input = input;
        }

        public IEnumerable<string> GetCommaSeparatedValues()
        {
            return input;
        }

        public IEnumerable<string> GetLines()
        {
            return input;
        }
    }
}
