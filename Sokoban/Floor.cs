using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Floor : Square
    {
        private Destination hasDestination;
        private DestroyableTile isDestroyable;
    }
}