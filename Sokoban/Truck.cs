﻿using System;
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
            Xposition = x;
            Yposition = y;
        }

        public override void move(int direction)
        {
            switch (direction)
            {
                case 1:
                    Xposition--;
                    break;

                case 2:
                    Yposition--;
                    break;

                case 3:
                    Xposition++;
                    break;

                case 4:
                    Yposition++;
                    break;
            }
        }

        //Verplaatsen van truck
       

        public override char toChar()
        {
            return '@';
        }
    }
}