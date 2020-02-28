using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IInput
    {
        IEnumerable<string> GetLines();
        IEnumerable<string> GetCommaSeparatedValues();
    }
}
