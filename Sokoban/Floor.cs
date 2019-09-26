using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Floor : Square
    {
        private Destination hasDestination;

        public int TileStatus
        {
            get => default;
            set
            {
            }
        }

        public void tileStatus()
        {
            throw new System.NotImplementedException();
        }
    }
}