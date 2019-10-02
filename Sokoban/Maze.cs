using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private Wall wall;
        private Floor floor;

        public int _width { get; set; } //breedte van het doolhof
        public int _height { get; set; }//hoogte van het doolhof
    }
}