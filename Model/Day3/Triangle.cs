namespace Model.Day3
{
    public static class Triangle
    {
        public static bool IsValid(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
