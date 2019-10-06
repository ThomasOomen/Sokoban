using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Truck : MoveableObjects
    {
        private int _xLoc;
        private int _yLoc;
        public Truck(int x, int y)
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

        //Verplaatsen van truck
        public override void move(int direction)
        {
            switch (direction)
            {
                case 1:
                    Console.WriteLine("truck naar links");
                    xLoc = _xLoc - 1;
                    break;

                case 2:
                    Console.WriteLine("truck naar omhoog");
                    yLoc = _yLoc - 1;
                    break;

                case 3:
                    xLoc = _xLoc + 1;
                    Console.WriteLine("truck naar rechts");
                    break;

                case 4:
                    yLoc = _yLoc + 1;
                    Console.WriteLine("truck naar omlaag");
                    break;
            }
        }

        public override char toChar()
        {
            return '@';
        }
    }
}