﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public abstract class Square
    {
        private int _Xposition { get; set; }
        private int _Yposition { get; set; }

        private MoveableObjects _MoveObject { get; set; }

        public int Xposition
        {
            get
            {
                return _Xposition;
            }
            set
            {
                _Xposition = value;
            }
        }

        public int Yposition
        {
            get
            {
                return _Yposition;
            }
            set
            {
                _Yposition = value;
            }
        }

        public MoveableObjects MoveObject
        {
            get
            {
                return _MoveObject;
            }
            set
            {
                _MoveObject = value;
            }
        }


        public bool IsEmpty()
        {
            if (this._MoveObject == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int SquareInDirection(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    return _Yposition - 1;
                case Direction.Down:
                    return _Yposition + 1;
                case Direction.Left:
                    return _Xposition - 1;
                case Direction.Right:
                    return _Xposition + 1;
                default:
                    return 0;
            }
        }
    }
}