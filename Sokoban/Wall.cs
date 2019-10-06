using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Wall : Square
    {

        private int _xLoc;
        private int _yLoc;
        public Wall(int x, int y)
        {
            xLoc = x;
            yLoc = y;
            this.DisplayChar = SetDisplayChar();

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
        public void checkColision()
        {
            throw new System.NotImplementedException();
        }

        public override char SetDisplayChar()
        {
            return '#';
        }
    }
}