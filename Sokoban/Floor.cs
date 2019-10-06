using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Floor : Square
    {
        private Destination hasDestination;
        private DestroyableTile isDestroyable;
        private Char displayChar;

        private int _xLoc;
        private int _yLoc;
        public Floor(int x, int y)
        {
            xLoc = x;
            yLoc = y;
            displayChar = '.';
        }
        public int xLoc
        {
            get
            {
                return this._xLoc;
            }
            set
            {
                this._xLoc = value;
            }
        }

        public int yLoc
        {
            get
            {
                return this._yLoc;
            }
            set
            {
                this._yLoc = value;
            }
        }

        public void SetDisplayChar()
        {
            if (this.IsEmpty())
            {
                displayChar = '.';
            }
            else
            {
                switch (this.MoveObject)
                {
                    case Crate:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}