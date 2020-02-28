namespace Model.Day2
{
    public class Keypad
    {
        private readonly int[,] keypad = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        private int RowPosition = 1, ColumnPosition = 1;

        public int GetNumber()
        {
            return keypad[RowPosition, ColumnPosition];
        }

        public void Move(char ch)
        {
            switch (ch)
            {
                case 'U':
                    MoveUp();
                    break;
                case 'D':
                    MoveDown();
                    break;
                case 'L':
                    MoveLeft();
                    break;
                case 'R':
                    MoveRight();
                    break;
                default:
                    break;
            }
        }

        private void MoveRight()
        {
            if (ColumnPosition < 2)
            {
                ColumnPosition++;
            }
        }

        private void MoveLeft()
        {
            if (ColumnPosition > 0)
            {
                ColumnPosition--;
            }
        }

        private void MoveDown()
        {
            if (RowPosition < 2)
            {
                RowPosition++;
            }
        }

        private void MoveUp()
        {
            if (RowPosition > 0)
            {
                RowPosition--;
            }
        }
    }
}
