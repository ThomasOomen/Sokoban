using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public abstract class Square
    {
        public Square Top { get; set; }
        public Square Bottom { get; set; }
        public Square Left { get; set; }
        public Square Right { get; set; }

        public abstract bool IsEmpty();

        public Square SquareInDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return this.Top;
                case Direction.Down:
                    return this.Bottom;
                case Direction.Left:
                    return this.Left;
                case Direction.Right:
                    return this.Right;
                default:
                    return null;
            }
        }
    }
}