using System;
using static System.Math;

namespace Model.Day2
{
    public class SpecialKeypad : Keypad
    {
        /// <summary>
        ///    1
        ///  2 3 4
        ///5 6 7 8 9
        ///  A B C
        ///    D
        /// Start at 5!
        /// </summary>
        public SpecialKeypad()
        {
            keypad = new char[5, 5] {
                { ' ', ' ', '1', ' ',' ' },
                { ' ', '2', '3', '4',' ' },
                { '5', '6', '7', '8','9' },
                { ' ', 'A', 'B', 'C',' ' },
                { ' ', ' ', 'D', ' ',' ' }
            };
            rowPosition = 2;
            columnPosition = 0;
        }

        protected override void MoveDown()
        {
            if (PositionValid(rowPosition + 1, columnPosition))
            {
                rowPosition++;
            }
        }

        protected override void MoveUp()
        {
            if (PositionValid(rowPosition - 1, columnPosition))
            {
                rowPosition--;
            }
        }

        protected override void MoveLeft()
        {
            if (PositionValid(rowPosition, columnPosition - 1))
            {
                columnPosition--;
            }
        }

        protected override void MoveRight()
        {
            if (PositionValid(rowPosition, columnPosition + 1))
            {
                columnPosition++;
            }
        }

        private bool PositionValid(int rowPosition, int columnPosition)
        {
            return Abs(rowPosition - 2) + Abs(columnPosition - 2) <= 2;
        }
    }
}
