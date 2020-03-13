namespace Model.Day3
{
    public static class Triangle
    {
        private static bool IsValid(int a, int b, int c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public static bool IsValid(params int[] sides) => IsValid(sides[0], sides[1], sides[2]);
    }
}
