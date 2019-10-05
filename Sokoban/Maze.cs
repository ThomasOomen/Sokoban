using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Maze
    {

        private Square[,] _grid { get; set; }

        public Square[,] Grid
        {
            get
            {
                return _grid;
            }
            set
            {
                _grid = value;
            }
        }
        public int _width { get; set; } //breedte van het doolhof
        public int _height { get; set; }//hoogte van het doolhof
    }
}