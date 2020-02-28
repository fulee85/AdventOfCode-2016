namespace Application
{
    public class Solution
    {
        public Solution(object firstPart, object secondPart = null)
        {
            FirstPart = firstPart.ToString();
            SecondPart = secondPart?.ToString() ?? "";
        }
        public string FirstPart { get; }
        public string SecondPart { get; }
    }
}
