using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class DestroyableTile : Square
    {
        private int _xLoc;
        private int _yLoc;
        public DestroyableTile(int x, int y)
        {
            xLoc = x;
            yLoc = y;
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
        public override bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}