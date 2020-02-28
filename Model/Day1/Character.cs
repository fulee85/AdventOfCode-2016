using Model.Common;
using Model.Exceptions;
using System;
using System.Collections.Generic;

namespace Model.Day1
{
    public class Character
    {
        private readonly HashSet<(int x, int y)> visitedPositions = new HashSet<(int x, int y)> { };
        private readonly Position position;
        private Direction direction;
        private int distanceFirstRevisitedPosition;

        public Character()
        {
            position = new Position(0, 0);
            direction = Direction.North;
            visitedPositions.Add((0, 0));
            IsFirstRevisitedPositionFound = false;
        }

        public void MakeMove(Movement movement)
        {
            ChangeDirection(movement.Turn);
            MakeSteps(movement.Steps);
        }

        public int GetTaxicabDistance()
        {
            return Math.Abs(position.X) + Math.Abs(position.Y);
        }

        public Position GetPosition() => position;
        public bool IsFirstRevisitedPositionFound { get; private set; }
        public int DistanceFirstRevisitedPosition 
        { 
            get => distanceFirstRevisitedPosition; 
            private set 
            {
                IsFirstRevisitedPositionFound = true;
                distanceFirstRevisitedPosition = value; 
            }
        } 

        private void MakeSteps(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                switch (direction)
                {
                    case Direction.North:
                        position.Y -= 1;
                        break;
                    case Direction.East:
                        position.X += 1;
                        break;
                    case Direction.South:
                        position.Y += 1;
                        break;
                    case Direction.West:
                        position.X -= 1;
                        break;
                    default:
                        break;
                }
                (int x, int y) = position;
                if (!IsFirstRevisitedPositionFound)
                {
                    if (visitedPositions.Contains((x, y)))
                    {
                        DistanceFirstRevisitedPosition = GetTaxicabDistance();
                    }
                    else
                    {
                        visitedPositions.Add((x, y));
                    }
                }
            }
        }

        private void ChangeDirection(Turn turn)
        {
            if (turn == Turn.Left)
            {
                direction = direction switch
                {
                    Direction.North => Direction.West,
                    Direction.West => Direction.South,
                    Direction.South => Direction.East,
                    Direction.East => Direction.North,
                    _ => throw new UnexpectedEnumValueException($"Unexpected enum value: {direction}")
                };
            }
            else
            {
                direction = direction switch
                {
                    Direction.North => Direction.East,
                    Direction.East => Direction.South,
                    Direction.South => Direction.West,
                    Direction.West => Direction.North,
                    _ => throw new UnexpectedEnumValueException($"Unexpected enum value: {direction}")
                };
            }
        }
    }
}
