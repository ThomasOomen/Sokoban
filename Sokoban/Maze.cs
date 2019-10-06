using System;
using System.Collections.Generic;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _width;
        private int _height;
        private Wall _objectWall;
        private Floor _objectFloor;
        private Crate _objectCrate;
        private Destination _objectDestination;
        private Truck _objectTruck;
        private DestroyableTile _objectDestroyableTile;
        private Coworker _objectCoworker;
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

        //breedte van het doolhof
        public int Width
        {
            get
            {
                return this._width;
            }
            set
            {
                this._width = value;
            }
        }

        //hoogte van het doolhof
        public int Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }

        //truck opvragen
        public Truck getTruck
        {
            get
            {
                return this._objectTruck;
            }
            set
            {
                this._objectTruck = value;
            }
        }

        public void SetGrid()
        {
            _grid = new Square[_width, _height];
        }

        internal void createMazeObjects(Char character, int x , int y)
        {
            string objectChar = Char.ToString(character);
            switch (objectChar)
            {
                case "#": //Muur
                    _objectWall = new Wall(x, y);
                    _grid[x, y] = _objectWall;
                    break;

                case ".": //Vloer
                    _objectFloor = new Floor(x, y);
                    _grid[x, y] = _objectFloor;
                    break;

                case "o": //Krat
                    _objectCrate = new Crate(x, y);
                    _objectFloor = new Floor(x, y);
                    _grid[x, y] = _objectFloor;
                    _grid[x, y].MoveObject = _objectCrate;

                    break;

                case "x": //Bestemming
                    _objectDestination = new Destination(x, y);
                    _grid[x, y] = _objectDestination;
                    break;

                case "@": //Truck
                    _objectTruck = new Truck(x, y);
                    _objectFloor = new Floor(x, y);
                    _grid[x, y] = _objectFloor;
                    _grid[x, y].MoveObject = _objectTruck;
                    break;

                case "~": //Valkuil
                    _objectDestroyableTile = new DestroyableTile(x, y);
                    _grid[x, y] = _objectDestroyableTile;
                    break;

                case "$": //Medewerker
                    _objectCoworker = new Coworker(x, y);
                    _objectFloor = new Floor(x, y);
                    _grid[x, y] = _objectFloor;
                    _grid[x, y].MoveObject = _objectCoworker;
                    break;
                default:
                    break;

            }
        }

        internal void getTruckLocation()
        {
            Console.WriteLine("truck heeft x locatie: " + _objectTruck.Xposition);
            Console.WriteLine("truck heeft y locatie: " + _objectTruck.Yposition);

        }

        internal void truckDirection(int direction)
        {
            _objectTruck.moveTruck(direction);
        }

        public void printArray()
        {
            for (int j = 0; j < _height; j++)
            {
                for (int i = 0; i < _width; i++)
                {
                    Console.Write(_grid[i, j].DisplayChar);
                }
                Console.WriteLine();
            }
        }
    }
}