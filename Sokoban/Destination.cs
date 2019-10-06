﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Destination : Square
    {
        private Char _displayChar;
        private int _xLoc;
        private int _yLoc;
        public Destination(int x, int y)
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
        public void checkBox()
        {
            throw new System.NotImplementedException();
        }

        public void SetDisplayChar()
        {
            if (this.IsEmpty())
            {
                _displayChar = 'X';
            }
            else
            {
                char c = this.MoveObject.toChar();
                switch (c)
                {
                    case 'o':
                        _displayChar = 'o';
                        break;
                    case '@':
                        _displayChar = '@';
                        break;
                    case 'Z':
                        _displayChar = 'Z';
                        break;
                    case '$':
                        _displayChar = '$';
                        break;
                    default:
                        break;
                }

            }
        }
    }
}