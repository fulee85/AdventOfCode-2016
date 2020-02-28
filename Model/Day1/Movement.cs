namespace Model.Day1
{
    public class Movement
    {
        public Movement(Turn turn, int steps)
        {
            Turn = turn;
            Steps = steps;
        }

        public Turn Turn { get; }
        public int Steps { get; }
    }
}
