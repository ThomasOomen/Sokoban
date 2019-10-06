using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Crate : MoveableObjects
    {
        private int _xLoc;
        private int _yLoc;
        public Crate(int x, int y)
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
        public override void move(int direction)
        {
            throw new NotImplementedException();
        }

        public override char toChar()
        {
            return 'o';
        }

    }
}