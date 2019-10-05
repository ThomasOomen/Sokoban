using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Truck : MoveableObjects
    {

        public int PositionX
        {
            get => default;
            set
            {
            }
        }

        public int PositionY
        {
            get => default;
            set
            {
            }
        }

        public override void move()
        {
            throw new NotImplementedException();
        }
    }
}