using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Destination : Square
    {
        private int _xLoc;
        private int _yLoc;
        public Destination(int x, int y)
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
        public void checkBox()
        {
            throw new System.NotImplementedException();
        }

        public override Char SetDisplayChar()
        {
            if (this.IsEmpty())
            {
                return 'x';
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
                        return 'x';

                }

            }
        }
    }
}