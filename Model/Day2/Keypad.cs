namespace Model.Day2
{
    public class Keypad
    {
        protected char[,] keypad;
        protected int rowPosition, columnPosition;

        public Keypad()
        {
            keypad = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            rowPosition = 1; 
            columnPosition = 1;
        }

        public char GetCode()
        {
            return keypad[rowPosition, columnPosition];
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

        protected virtual void MoveRight()
        {
            if (columnPosition < 2)
            {
                columnPosition++;
            }
        }

        protected virtual void MoveLeft()
        {
            if (columnPosition > 0)
            {
                columnPosition--;
            }
        }

        protected virtual void MoveDown()
        {
            if (rowPosition < 2)
            {
                rowPosition++;
            }
        }

        protected virtual void MoveUp()
        {
            if (rowPosition > 0)
            {
                rowPosition--;
            }
        }
    }
}
