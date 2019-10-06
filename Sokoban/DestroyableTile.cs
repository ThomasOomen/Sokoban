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
                return '~';
            }
            else
            {
                char c = this.MoveObject.toChar();
                switch (c)
                {
                    case 'o':
                       return 'o';
                        break;
                    case '@':
                        return '@';
                        break;
                    case 'Z':
                        return 'Z';
                        break;
                    case '$':
                       return '$';
                        break;
                    default:
                        return '~';
                        break;
                }

            }
        }
    }
}