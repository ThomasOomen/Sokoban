using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Floor : Square
    {

        private int _xLoc;
        private int _yLoc;
        public Floor(int x, int y)
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

        public override Char SetDisplayChar()
        {
            if (this.IsEmpty())
            {
               return '.';
            }
            else
            {
                char c = this.MoveObject.toChar();
                switch (c)
                {
                    case 'o':
                        return 'o';

                    case '@':
                        return '@';

                    case 'Z':
                        return 'Z';

                    case '$':
                        return '$';

                    default:
                        return '.';

                }

            }
        }
    }
}